﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireDelay = 0.15f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {
       cooldownTimer -= Time.deltaTime;

       if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
           Debug.Log("Pew pew");
           cooldownTimer = fireDelay;

           Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

           Instantiate(bulletPrefab, transform.position + offset, transform.rotation);

       } 
    }
}
