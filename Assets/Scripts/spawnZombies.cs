using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnZombies : MonoBehaviour
{
    [SerializeField] private GameObject spawnZombiesPrefab;
    [SerializeField] private Canvas instructions;
    private float minX = -15f;
    private float maxX = 15f;
    private float minZ = -26f;
    private float maxZ = 6f;
    private float Y = 0.05f;
    [SerializeField] private float spawnDelay = 2f;
    [SerializeField] private float spawnApmlifier;
    private bool spawn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Timer")
        {
            Destroy(instructions);
            InvokeRepeating("spawnZombie", 0, spawnDelay);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void spawnZombie()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 location = new Vector3(randomX, Y, randomZ);
        Instantiate(spawnZombiesPrefab, location, Quaternion.identity);    
    }  
}
