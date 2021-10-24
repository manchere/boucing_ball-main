using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour
{
    public float speed;
    public float clampX = 36f;
    void Start()
    {
        //Instantiate(brique, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -clampX, clampX);
        transform.position = pos;
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}
