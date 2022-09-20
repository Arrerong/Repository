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

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isJogging", false);
        }
    }
}