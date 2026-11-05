using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;//bala
    public GameObject shootingPoint;//punto de partida
    public void OnFire(InputValue value)//al precionar left click
    {
        print("dispare");
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);//instanciar bala
            //donde sale la bala
            clone.transform.position = shootingPoint.transform.position;
            clone.transform.rotation = shootingPoint.transform.rotation;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{

}
