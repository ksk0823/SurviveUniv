using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 3.0f;

    private bool isMoving = false; // �÷��̾� �̵� ����
    private SpriteRenderer spriteRenderer; // �÷��̾� ��������Ʈ ������ ������Ʈ

    private Animator animator;

    private void Start()
    {
        // ���� ���� �� �÷��̾��� �ʱ� ��ġ ����
        transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        // �÷��̾� �̵�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = false;
            this.animator.speed = moveSpeed/3.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = true;
            this.animator.speed = moveSpeed/3.0f;
        }
        else
        {
            isMoving = false;

        }

        if (!isMoving)
        {
            this.animator.speed = 0f;
            spriteRenderer.sprite = Resources.Load<Sprite>("man");
            transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
        }

        
    }
}
