using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    int health = 1;
    void OnTriggerEnter2D(){
        Debug.Log ("Trigger!");

        health--;
    }

    void Update(){
        if(health <= 0) {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }
    
    

}
