using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zonefin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "balle")
        {
            SceneManager.LoadScene("Start_screen");
            Debug.Log("fin du jeu");
        }
    }
}
