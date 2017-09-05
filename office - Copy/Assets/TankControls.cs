using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class TankControls : MonoBehaviour
{



    public float moveSpeed = 3.0f;

    public float rotationSpeed = 90.0f;



    // Update is called once per frame

    void Update()
    {



        float rotateCharacter = Input.GetAxis("Horizontal");

        float moveCharacter = Input.GetAxis("Vertical");

        Debug.Log("Rotation: " + rotateCharacter);



        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveCharacter;



        transform.Rotate(Vector3.up * rotationSpeed * rotateCharacter * Time.deltaTime);

    }

}