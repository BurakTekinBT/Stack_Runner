using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI powerText;
    private int stackCount = 0;
    public static ScoreManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void UpdateDisplayText()
    {
        stackCount++;
        powerText.text = "Power Fragment: " + stackCount;
    }
}
