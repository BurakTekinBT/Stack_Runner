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
    // Start is called before the first frame update

    public void UpdateDisplayText()
    {
        stackCount++;
        powerText.text = "Power Fragment: " + stackCount;
    }
}
