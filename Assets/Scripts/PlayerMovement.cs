using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MovementSpeed = 5f;
    [SerializeField] private float JumpHeight = 10f;
    private Rigidbody2D body;
    private bool grounded;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.freezeRotation = true;
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * MovementSpeed, body.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            Jump();
        // Исключение прыжка при обычном падении
        if (body.velocity.y < -1f)
            grounded = false;
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, JumpHeight);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
