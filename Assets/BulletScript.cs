﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
           
        }
  

    }
}
