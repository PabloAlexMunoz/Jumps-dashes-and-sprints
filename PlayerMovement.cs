using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float Speed;
    [SerializeField] private float rotationSpeed;
    private Vector2 movementValue;
    private Vector2 dodgeDirection;
    private Vector2 lastdir;
    private float lookValue;
    private Rigidbody rb;
    private bool isSprinting;
    private bool isDodging;
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }
    public void OnShift(InputValue value)
    {
        print("OnShift called: " + value.isPressed);

        isSprinting = value.isPressed;
    }

    public void OnDodge(InputValue value)
    {
        print("dodged");
        isDodging = true;
        dodgeDirection = lastdir;
    }
    public void OnMove(InputValue value)
    {

        movementValue = value.Get<Vector2>();
        if(movementValue != Vector2.zero)
        {
            lastdir = movementValue.normalized;
        }
    }
    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x*rotationSpeed;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float newSpeed = Speed;
        if (isDodging)
        {
            newSpeed = Speed*10;
            transform.Translate(dodgeDirection.x*Time.deltaTime*newSpeed,
            0,
            dodgeDirection.y*Time.deltaTime*newSpeed);
            isDodging = false;
        }     
        else if (isSprinting)
        {
            newSpeed = Speed*3;
        } 
 

       
        transform.Translate(movementValue.x*Time.deltaTime*newSpeed,
        0,
        movementValue.y*Time.deltaTime*newSpeed);
        transform.Rotate(0, lookValue*Time.deltaTime, 0);
       

    }
}
