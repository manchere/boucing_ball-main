using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balle : MonoBehaviour
{
    public Vector3 deplacement;
    public GameObject prefabDebris;
    private int nbrBriques = 0;
    private int briqueCount;

    void Start()
    {
       briqueCount= Bonus.CountObject("brique");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = deplacement;
    }

    void OnCollisionEnter(Collision collision)
    {
        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal);
        if (collision.gameObject.tag == "brique")
        {
            Destroy(collision.gameObject);
            DebrisPieces(4);
            ScoreManager.instance.AddPoint();
            nbrBriques++;
            if (nbrBriques >= briqueCount)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    void DebrisPieces(int number){
        for (int i = 0; i < number; i++)
        {
            Instantiate(prefabDebris, transform.position, Quaternion.identity);
        }   
    }
}
