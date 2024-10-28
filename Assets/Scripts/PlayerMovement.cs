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

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponentInChildren<SpriteRenderer>();
        animations = GetComponentInChildren<PlayerAnimations>();
    }

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }
    void Move()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += input * speed * Time.deltaTime;

        isMoving = input.x != 0 ? true : false;
        if (isMoving) playerSprite.flipX = input.x > 0 ? false : true;
        animations.IsMoving= isMoving;
    }

    void Jump()
    {
        Debug.Log("Jump");
        rigidbody.AddForce(transform.up * jumpForce);
    }
}
