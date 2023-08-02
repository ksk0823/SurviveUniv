using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    private bool isGameOver;

    public GameObject player;
    public FinalScoreUI finalS;

    private void Start()
    {
        isGameOver = false;
        player = GameObject.Find("player");
        finalS = GameObject.Find("FinalScore").GetComponent<FinalScoreUI>();
    }

    private void Update()
    {
        if (isGameOver)
        {
            // 게임 오버 시 게임을 멈추기 위해 Time.timeScale 값을 0으로 설정
            Time.timeScale = 0f;
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        player.SetActive(false);
        finalS.ViewFinalScore();
    }
}
