using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isJogging", true);
        }        
        
        else if (Input.GetKey("a"))
        {
            animator.SetBool("isJogging", true);
        }
        
        else if (Input.GetKey("s"))
        {
            animator.SetBool("isJogging", true);
        }
        
        else if (Input.GetKey("d"))
        {
            animator.SetBool("isJogging", true);
        }

        else if (!Input.GetKey("w"))
        {
            animator.SetBool("isJogging", false);
        }
        
        else if (!Input.GetKey("a"))
        {
            animator.SetBool("isJogging", false);
        }
        
        else if (!Input.GetKey("s"))
        {
            animator.SetBool("isJogging", false);
        }
        
        else if (!Input.GetKey("d"))
        {
            animator.SetBool("isJogging", false);
        }

        if (Input.GetMouseButton(1))
        {
            animator.SetBool("isAiming",true);
        }
        
        else if (!Input.GetMouseButton(1))
        {
            animator.SetBool("isAiming",false);
        }
    }
}