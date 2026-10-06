using UnityEngine;
using UnityEngine.InputSystem;
public class SpawnManger : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    public int animalsIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) 
        { 
             int animalsIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalsIndex], new Vector3(Random.Range(-20f, 20f), 0, 20f), animalPrefabs[animalsIndex].transform.rotation);
        }
    }
}
