using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 playerScale;
    float scaleUp = 0.2f;

    public Vector3 PlayerScale { get => playerScale; set => playerScale = value; }

    private void Start()
    {
        
    }
    public void Upscale()
    {
        transform.localScale = new Vector3(transform.localScale.x + scaleUp, transform.localScale.y + scaleUp, transform.localScale.z + scaleUp);
    }
}
