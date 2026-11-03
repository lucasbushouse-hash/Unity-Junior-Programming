using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Prefab;
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPrefab", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPrefab()
    {
        Instantiate(Prefab, spawnPosition, Prefab.transform.rotation);
    }
}
