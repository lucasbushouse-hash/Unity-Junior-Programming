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
            SpawnRandomAnimal();
        }
    }

        void SpawnRandomAnimal(){
             int animalsIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalsIndex], spawnPos, animalPrefabs[animalsIndex].transform.rotation);
        }
    }

    
}
