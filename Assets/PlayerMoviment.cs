using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float groundDistance = 0.25f;
    [SerializeField] private float jumpTime = 0.3f;

    private bool isGrounded = false;
    private bool isJumping = false;
    private float jumpTimer;

    private void Update()
    {
        // Controllo se il giocatore è a terra
        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);

        // Controllo del salto tramite input
        if (isGrounded && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isJumping = true;
            rb.velocity = Vector2.up * jumpForce;
            animator.SetBool("IsJumping", true);
        }

        // Gestione del salto prolungato
        if (isJumping && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            if (jumpTimer < jumpTime)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimer += Time.deltaTime;
            }
            else
            {
                isJumping = false;
                animator.SetBool("IsJumping", false);
            }
        }

        // Interruzione del salto
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            isJumping = false;
            jumpTimer = 0;
            animator.SetBool("IsJumping", false);
        }
    }
}
