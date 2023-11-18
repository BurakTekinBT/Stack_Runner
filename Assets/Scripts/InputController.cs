using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IDragHandler
{
    bool isClicked=false;
    public GameObject player;
    public GameObject otherPlayer;
    public float moveSensitivity;
    private void Update()
    {
        if (!isClicked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartTheGame();

                isClicked = true;
            }
        }
    }
    void StartTheGame()
    {
        GameManager.Instance.StartTheGame();
    }

    public void OnDrag(PointerEventData eventData)
    {
        float movement;
        movement = eventData.delta.x;

        player.transform.position += new Vector3(movement * moveSensitivity * Time.deltaTime, 0, 0);
        otherPlayer.transform.position -= new Vector3(movement * moveSensitivity * Time.deltaTime, 0, 0);
    }
}
