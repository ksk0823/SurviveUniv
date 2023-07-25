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
        //�����Ӹ��� ������� ���� ��Ų��
        transform.Translate(0, -0.05f, 0);

        //ȭ�� ������ ������ ������Ʈ �Ҹ�
        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }

        //�浹 ����
        Vector2 p1 = transform.position;     //ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;    //�÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    //ȭ���� �ݰ�
        float r2 = 1.0f;    //�÷��̾��� �ݰ�

        if (d < r1 + r2)
        {
            //�浹�� ��� ȭ���� ����
            score.Num++;
            score.Score += 2.0f;
            Destroy(gameObject);
        }
    }
}
