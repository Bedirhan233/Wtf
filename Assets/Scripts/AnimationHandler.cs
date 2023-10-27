using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    Animator animator;
    

    public bool smalCharacterWalking;
    public bool isJumping;
    public bool isFalling;

    bool smalCharacter;
    bool bigCharacter;

    public bool bigCharacterWalking;
    public bool bigCharacterJumping;

    public bool isThrowing;

    
    bool smalCharacterFalling;
    bool smalCharacterLanding;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "SmalGuy")
        {
        SmalCharacterWalkingAnimation();

        }

        if(gameObject.tag == "BigGuy")
        {
            BigCharacterWalkingAnimation();
        }


        ThrowingAnimation();
        SmalCharacterIsJumping();
        SmalCharacterFalling();
        BigCharacterWalking();
        BigCharacterJumpingAnimation();

    }

    void SmalCharacterWalkingAnimation()
    {

        if(smalCharacterWalking) 
        { 
        animator.SetBool("IsWalking", true);
        }
        
        if (!smalCharacterWalking)
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void BigCharacterWalkingAnimation()
    {

        if (smalCharacterWalking)
        {
            animator.SetBool("IsWalking", true);
        }

        if (!smalCharacterWalking)
        {
            animator.SetBool("IsWalking", false);
        }

    }

    

    void SmalCharacterIsJumping()
    {
        if(isJumping) 
        {
            animator.SetBool("isJumping", true);
            
            
        }

        if (!isJumping)
        {
            animator.SetBool("isJumping", false);
            
        }
    }

    void SmalCharacterFalling()
    {
        if(isFalling) 
        {
            animator.SetBool("isFalling", true);
        }
        if (!isFalling)
        {
            animator.SetBool("isFalling", false);
        }

    }

    void BigCharacterWalking()
    {
        if(bigCharacterWalking)
        {
            animator.SetBool("BigGuyWalking", true);
        }

        if(!bigCharacterWalking)
        {
            animator.SetBool("BigGuyWalking", false);
        }
    }
    void BigCharacterJumpingAnimation()
    {
        if(isJumping)
        {
        animator.SetBool("bigGuyJump", true);
        }

        if (!isJumping)
        {
            animator.SetBool("bigGuyJump", false);
        }
    }

    void ThrowingAnimation()
    {
       
        if(isThrowing)
        {
            animator.SetBool("isThrowing", true);
            

        }
        if (!isThrowing)
        {
            animator.SetBool("isThrowing", false);

        }



    }
}
