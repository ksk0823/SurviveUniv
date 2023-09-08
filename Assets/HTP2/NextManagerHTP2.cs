using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NextManagerHTP2 : MonoBehaviour
{
    public Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Next").GetComponent<Button>();
    }

    public void NextGame()
    {

        SceneManager.LoadScene("Game2", LoadSceneMode.Single);
        //
    }
}
