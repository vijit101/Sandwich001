using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float zMaxBound = 30;
    public float zMinBound = -10;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zMaxBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < zMinBound)
        {
            Destroy(gameObject);
        }
    }
}
