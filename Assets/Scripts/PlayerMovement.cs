using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private SpriteRenderer playerSprite;
    private Rigidbody2D rigidbody;
    private PlayerAnimations animations;
    
    private Vector3 input;
    private bool isMoving;
    private bool isGrounded;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponentInChildren<SpriteRenderer>();
        animations = GetComponentInChildren<PlayerAnimations>();
    }

    void FixedUpdate()
    {
        Move();
        Jump();
    }
    void Move()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.Translate(speed * input * Time.fixedDeltaTime);


        isMoving = input.x != 0 ? true : false;
        if (isMoving) playerSprite.flipX = input.x > 0 ? false : true;
        animations.IsMoving= isMoving;
    }

    void Jump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (isGrounded)
            {
                rigidbody.AddForce(Vector3.up * jumpForce);
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        IsGroundedUpate(collision, true);
    }


    private void IsGroundedUpate(Collision2D collision, bool value)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = value;
        }
    }
}
