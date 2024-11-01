using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float jumpForce = 1f;
    Animator animator;
    bool isJumping;
    Transform playerSpriteTransform;
    [SerializeFIeld] Vector3 spriteRotationOnJump;

    const string jumpParameter = "isJumping";

    private void Start()
    {
        rb2D=GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        playerSpriteTransform = transform.GetChild(0);
    }

    
    private void Update()
    {
        if (isJumping)
        {
            if (rb2D.linearVelocity.y<=0f)
            {
                isJumping = false;
                animator.SetBool(jumpParameter,isJumping);
            }
        }
    }
 
    public void jump()
    {
        rb2D.linearVelocity=Vector2.up * jumpForce;
        isJumping=true;
        animator.SetBool(jumpParameter, isJumping);
        playerSpriteTransform.rotation = Quaternion.Euler(spriteRotationOnJump);
    }
}


