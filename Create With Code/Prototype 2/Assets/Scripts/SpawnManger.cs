using UnityEngine;
using UnityEngine.InputSystem;
public class SpawnManger : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangex = 20f;
    private float spawnRangeZ = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        
        spawnAction.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.triggered)
        {
            SpawnRandomAnimal();
        }
    }

        void SpawnRandomAnimal(){
             int animalsIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(animalPrefabs[animalsIndex], spawnPos, animalPrefabs[animalsIndex].transform.rotation);
        }
    }


