using UnityEngine;
using UnityEngine.InputSystem;
public class PropellerMovement : MonoBehaviour
{
    public float Speed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Speed * Time.deltaTime);
    }
}
