using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMoreController : MonoBehaviour
{
    public Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Main").GetComponent<Button>();
    }

    public void NextGame()
    {

        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        //
    }
}
