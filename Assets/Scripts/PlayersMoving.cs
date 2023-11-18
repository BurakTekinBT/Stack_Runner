using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayersMoving : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;

    void Update()
    {
        isCharacterRunning();
    }

    void isCharacterRunning()
    {
        if (GameManager.Instance.isGameStarted)
        {
            transform.position += Vector3.forward * _playerSpeed * Time.deltaTime;
        }
    }
}
