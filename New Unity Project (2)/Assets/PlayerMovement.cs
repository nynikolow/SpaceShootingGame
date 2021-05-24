using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;
     void Start()
    {
        
    }

    void Update()
    {
        // РОТАЦИЯ 

        // вземаме rotation quaternion
        Quaternion rot = transform.rotation;

        // вземаме ъгъл Z euler
        float z = rot.eulerAngles.z;

        // променяме Z ъгълът спрямо input-а
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        // обновяваме quaternion-а
        rot = Quaternion.Euler ( 0, 0, z);

        transform.rotation = rot;

        // ДВИЖЕНИЕ 
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        pos += rot * velocity;

        transform.position = pos;





    }
}
