using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    private CharacterController _controller;
    public float speed = 12f;
    public float gravity = 9.81f * 2;
    public float jumpHeigth = 3f;
    public int maxJumps;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    private int jumps;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    bool isMoving;
    Vector3 lastPosition = new Vector3(0f, 0f, 0f);

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {
    //GroundCheck
    isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
    if (isGrounded && velocity.y < 0)
    {
        velocity.y = -2f;
        
    }
    //Get Inputs
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    
    //Move Calc

    Vector3 move = transform.right * x + transform.forward * z;

    //Move App
    _controller.Move(move * (speed * Time.deltaTime));
    
    //Check Jump Availability
    if (!(maxJumps == 0))
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeigth * -2f * gravity);
            jumps++;
        }

        if (Input.GetButtonDown("Jump") && !isGrounded && (jumps <= maxJumps))
        {
            velocity.y = Mathf.Sqrt(jumpHeigth * -2f * gravity);
            jumps++;
        }

        if (jumps > maxJumps && isGrounded)
        {
            jumps = 0;
        }
        
    }
    //Constant Gravity
    velocity.y += gravity * Time.deltaTime;
    _controller.Move(velocity * Time.deltaTime);
    //Move Check
    if (lastPosition != gameObject.transform.position && isGrounded == true)
    {
        isMoving = true;
    }
    else
    {
        isMoving = false;
    }
    }
    
}