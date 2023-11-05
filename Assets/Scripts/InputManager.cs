using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerMovement blackPlayerMovement;
    public PlayerMovement redPlayerMovement;
    public float initialXPos;
    public float xOffset;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            initialXPos = Input.mousePosition.x;
            Debug.Log("Bastý");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("basýlýyor");
            xOffset = Input.mousePosition.x - initialXPos;


        }
        redPlayerMovement.Move(xOffset);
        blackPlayerMovement.Move(-xOffset);

    }
}
