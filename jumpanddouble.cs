using UnityEngine;
using UnityEngine.InputSystem;

public class jumpanddouble : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    private Rigidbody rb;
    private int jumps;
    public int maxJumps;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnJump(InputValue value)
    {
        if (value.isPressed && jumps < maxJumps)
        {
            rb.AddForce(Vector3.up*jumpPower, ForceMode.Impulse);
            jumps +=1;
        }
    }

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
