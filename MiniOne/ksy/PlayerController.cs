using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1.5f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1.5f, 0, 0);
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        case "A":
            ScoreAText.scoreValue++;
            break;
        case "B":
            ScoreBText.scoreValue++;
            break;
        case "C":
            ScoreCText.scoreValue++;
            break;
        case "D":
            ScoreDText.scoreValue++;
            break;
        case "F":
            ScoreFText.scoreValue++;
            break;
    }
    */
}