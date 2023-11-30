using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruMove : MonoBehaviour
{

    public float hiz;

    void Start()
    {
        Destroy(gameObject, 7);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * hiz *Time.deltaTime;
    }
	
}
