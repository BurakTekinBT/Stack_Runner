using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerShards : MonoBehaviour
{
    public MergedPlayer mergedplayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.UpdateDisplayText();
            mergedplayer.Upscale();
        }
    }
}
