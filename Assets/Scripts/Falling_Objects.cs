using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Falling_Objects : MonoBehaviour
{
    public GameObject[] objectSpawn; 
    public float minX = -3.5f;
    public float maxX = 3.5f;
    public float spawnY = 4f; 
    public float spawnZ = -2.5f;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        foreach (GameObject obj in objectSpawn)
        {
            int num = Random.Range(0, 2); 
            for (int i = 0; i < num; i++)
            {
                float randomX = Random.Range(minX, maxX);
                Vector3 newPosition = new Vector3(randomX, spawnY, spawnZ);
                Instantiate(obj, newPosition, Quaternion.identity);
            }
        }
    }
}