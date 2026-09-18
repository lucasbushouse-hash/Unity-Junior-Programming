using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float speed = 20.0f;
     public float turnSpeed = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transfor.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
