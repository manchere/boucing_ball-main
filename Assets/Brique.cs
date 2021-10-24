using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brique : MonoBehaviour
{
    public GameObject briquePrefab;
    void Start()
    {
        spawnBrique(1, 10);
        spawnBrique(1,8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnBrique(int num, int height)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject clone = Instantiate(briquePrefab) as GameObject;
            clone.transform.position = new Vector2(Random.Range(-35, 35), height);
        }
        
    }
}
