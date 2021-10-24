using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisBrique : MonoBehaviour
{
    public float force = 10f;
    void Start()
    {
        Vector3 motion = new Vector3(Random.Range(-1f, 1f), 1, 0);
        GetComponent<Rigidbody>().AddForce(motion * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
