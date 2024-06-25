using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Falling_Objects : MonoBehaviour
{
   public GameObject martillo;  
   public float minX = -3.5f; 
   public float maxX = 3.5f; 
   public float Y = 4f; 

   
    // Start is called before the first frame update
    void Start() 
    { 
        SpawnObjects();
    } 
    
    // Update is called once per frame 
    void SpawnObjects()

    { 
        int numberSpawned = Random.Range(1, 6);
        for (int i = 0; i < numberSpawned; i++)
        { 
            float randomX = Random.Range(minX, maxX); 
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity); 
        } 
    } 
}