using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MergedPlayer : MonoBehaviour
{
    float scaleUp = 0.5f;
    public void Upscale()
    {
        transform.localScale = new Vector3(
            transform.localScale.x + scaleUp, 
            transform.localScale.y + scaleUp, 
            transform.localScale.z + scaleUp);
    }
}
