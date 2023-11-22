using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject winScreen;
    public GameObject loseScreen;
    public bool isGameStarted = false;

    public GameObject p1;
    public GameObject p2;
    public GameObject merged;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartTheGame()
    {
        isGameStarted = true;
    }

    public void WinState()
    {
        FinalMove();
        winScreen.SetActive(true);
    }

    public void LoseState()
    {
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
    }

    public void FinalMove()
    {
        p1.transform.DOMoveX(merged.transform.position.x ,2f);
        p2.transform.DOMoveX(merged.transform.position.x, 2f);
    }
}
