using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HakjumController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;



    void Start()
    {
        this.player = GameObject.Find("player");
 
       
       
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        
        if (d < r1 + r2)
        {
            Total.total += 1;
            Destroy(gameObject);
            Sfx.SoundPlay();
            
        }
        

    }
}
