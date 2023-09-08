using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockController : MonoBehaviour
{
    public Animator animator;
    public bool isRinging;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.enabled = false;
        isRinging = false;
    }

    public void RingClock()
    {
        animator.enabled = true;
        this.animator.speed = 1.0f;
        isRinging = true;
    }
}
