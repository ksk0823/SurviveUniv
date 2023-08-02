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
            // ���� ���� �� ������ ���߱� ���� Time.timeScale ���� 0���� ����
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
