using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(PlayerInputController))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private PlayerInputController input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInputController>();
    }

    private void Update()
    {
        // Déplacement gauche/droite
        Vector2 move = input.MoveInput;
        rb.linearVelocity = new Vector2(move.x * moveSpeed, rb.linearVelocity.y);

        // Saut simple
        if (input.JumpPressed && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
        // À remplacer plus tard par un vrai raycast
        return Mathf.Abs(rb.linearVelocity.y) < 0.01f;
    }
}