using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public static int CountObject(string name)
    {
        return GameObject.FindGameObjectsWithTag(name).Length;
    }
}
