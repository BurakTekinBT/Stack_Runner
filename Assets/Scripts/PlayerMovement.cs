using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float playerSpeed = 5f;
    float movementSensivity = 0.05f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.forward*Time.deltaTime*playerSpeed;
    }

    public void Move(float offset)
    {
        transform.position += new Vector3(offset * movementSensivity, transform.position.y, transform.position.z);
    }
}
