using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    private CharacterController _controller;
    public float speed = 12f;
    public float gravity = 9.81f * 2;
    public float jumpHeigth = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;

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
    if (Input.GetButtonDown("Jump") && isGrounded)
    {
        velocity.y = Mathf.Sqrt(jumpHeigth * -2f * gravity);
    }
        //Constant Gravity
    velocity.y += gravity * Time.deltaTime;
        //Jumping Translocation
    _controller.Move(velocity * Time.deltaTime);
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