using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Falling_Objects : MonoBehaviour
{
   public GameObject spawnObjects;  
   public Vector3 newPosition; 
   public float minX = -3.5; 
   public float maxX = 3.5; 
   // Start is called before the first frame update
    void Start() 
    { 
        
    } 

    // Update is called once per frame 
    void Update()
    { 
        int numberSpawned = Random.Range(1, 6);
        for (int i = 0; i < NumberSpawned; i++)
        { 
            float randomX = Random.Range(minX, maxX); 
            Vector3 newPosition = new Vector3(randomX, transform.position.y.transform.position.z); 
            Instantiate(spawnObjects, newPosition, Quaternion.identity); 
        } 
    } 
}

