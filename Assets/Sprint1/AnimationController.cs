using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("rightStrafe", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("rightStrafe", false);
        }
        if (Input.GetKey("a"))
        {
            animator.SetBool("leftStrafe", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("leftStrafe", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", false);
        }

    }
}
