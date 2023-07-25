using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBallController : MonoBehaviour
{
    private GameObject player;
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하 시킨다
        transform.Translate(0, -0.05f, 0);

        //화면 밖으로 나오면 오브젝트 소멸
        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position;     //화살의 중심 좌표
        Vector2 p2 = this.player.transform.position;    //플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    //화살의 반경
        float r2 = 1.0f;    //플레이어의 반경

        if (d < r1 + r2)
        {
            //충돌한 경우 화살을 지움
            score.Num++;
            score.Score += 2.0f;
            Destroy(gameObject);
        }
    }
}
