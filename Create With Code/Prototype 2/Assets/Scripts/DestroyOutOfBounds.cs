using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopBound = 30f;
    private float LowerBound = -10f;

    void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}

