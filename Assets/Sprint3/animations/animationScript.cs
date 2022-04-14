using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
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
       
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("isSlashing", true);
        }
        
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("isSlashing", false);
        }
    }
}