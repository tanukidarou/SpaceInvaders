﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBulletScript : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 2);
    }

    void Update()
    {
        transform.Translate(Vector3.down * 0.08f);
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}