using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Prefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Prefab, spawnPosition, Prefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
