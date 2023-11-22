using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("EvolvedPlayer"))
        {
            GameManager.Instance.LoseState();
        }
    }
}
