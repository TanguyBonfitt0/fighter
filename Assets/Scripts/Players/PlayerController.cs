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
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Mouvement horizontal
        Vector2 move = input.MoveInput;
        rb.linearVelocity = new Vector2(move.x * moveSpeed, rb.linearVelocity.y);

        // Saut
        if (input.JumpPressed && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
        return Mathf.Abs(rb.linearVelocity.y) < 0.01f;
    }
}