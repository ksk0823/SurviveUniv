using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    private bool isGameOver;

    private void Start()
    {
        isGameOver = false;
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
        // ���� ���� ó�� �ؾ��ϴµ�,,,
    }
}
