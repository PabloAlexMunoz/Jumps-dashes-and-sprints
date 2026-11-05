using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float Speed; //velocidad
    [SerializeField] private float rotationSpeed; //velocidad de mirada
    private Vector2 movementValue; //valor de movimiento para input
    private Vector2 dodgeDirection;//valor direccional del dodge
    private Vector2 lastdir; //valor direccional previo
    private float lookValue;//valor direccional de mirada
    private bool isSprinting;//para verificar shift
    private bool isDodging;//para verificar doble pulso
    private void Awake()
    {//hacer invicible el mouse
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void OnShift(InputValue value)//esta siendo pulsado shift?
    {
        print("OnShift called: " + value.isPressed);

        isSprinting = value.isPressed;
    }

    public void OnDodge(InputValue value)//doble pulso de un boton
    {
        print("dodged");
        isDodging = true;
        dodgeDirection = lastdir;//previa direccion
    }
    public void OnMove(InputValue value)//direccion de movimiento
    {

        movementValue = value.Get<Vector2>();
        if(movementValue != Vector2.zero)
        {
            lastdir = movementValue.normalized;//poner en lastdir la direccion
        }
    }
    public void OnLook(InputValue value)//valor de mirada
    {
        lookValue = value.Get<Vector2>().x*rotationSpeed;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float newSpeed = Speed;//valor temporero, guardar original
        if (isDodging)//Dodge
        {
            newSpeed = Speed*10;//multiplicar velocidad
            transform.Translate(dodgeDirection.x*Time.deltaTime*newSpeed,
            0,
            dodgeDirection.y*Time.deltaTime*newSpeed);
            isDodging = false;//update que termino
        }     
        else if (isSprinting)//multiplicar velocidad mientras shift es precionado
        {
            newSpeed = Speed*3;
        } 
 

       //movimiento normal o sprint
        transform.Translate(movementValue.x*Time.deltaTime*newSpeed,
        0,
        movementValue.y*Time.deltaTime*newSpeed);
        transform.Rotate(0, lookValue*Time.deltaTime, 0);
       

    }
}
