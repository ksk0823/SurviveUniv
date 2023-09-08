using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    private bool isGameOver;

    public GameObject player;
    public FinalScoreUI finalS;
    public GameObject nt;

    private void Start()
    {
        isGameOver = false;
        //player = GameObject.Find("player");
        finalS = GameObject.Find("FinalScore").GetComponent<FinalScoreUI>();
        nt = GameObject.Find("Next");
        nt.SetActive(false);
    }

    private void Update()
    {
        if (isGameOver)
        {
            // ???? ???? ?? ?????? ?????? ???? Time.timeScale ???? 0???? ????
            Time.timeScale = 0f;
        }
    }

    public void GameOver()
    {
        player = GameObject.Find("player");
        isGameOver = true;
        this.player.SetActive(false);
        finalS.ViewFinalScore();
        nt.SetActive(true);
    }
}
