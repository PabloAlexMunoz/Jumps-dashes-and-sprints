using UnityEngine;
using UnityEngine.InputSystem;

public class jumpanddouble : MonoBehaviour
{
    [SerializeField] private float jumpPower; //potencia de brinco
    private Rigidbody rb; 
    private int jumps; //brincos realizados
    public int maxJumps; //cantidad maxima de brincos

    //obtener el componente rigidbody
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    //funcion al brincar (presionar espacio)
    public void OnJump(InputValue value)
    {
        // cuando boton se  presiona  y brincos realizados es menor que cantidad total
        if (value.isPressed && jumps < maxJumps)
        {
            rb.AddForce(Vector3.up*jumpPower, ForceMode.Impulse); //añadir fuerza de impulso al rigidbody
            jumps +=1;
        }
    }

    // reiniciar brincos al tocar el piso
    void OnCollisionStay(Collision c)
    {
        jumps = 1;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
