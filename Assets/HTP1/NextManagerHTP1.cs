using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NextManagerHTP1 : MonoBehaviour
{
    public Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Next").GetComponent<Button>();
    }

    public void NextGame()
    {

        SceneManager.LoadScene("Game1", LoadSceneMode.Single);
        //
    }
}
