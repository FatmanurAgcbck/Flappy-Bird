using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    private void Start()
    {
        //borular geldikten 5 saniye sonra yok olacak
        Destroy(gameObject, 5);
    }
    

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
