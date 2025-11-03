using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject ghostPrefab;
   
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGhosts", 1, 10);
    }

    // Spawn random ghost at random x position at top of play area
    void SpawnGhosts ()
    {
         int ghostIndex = Random.Range(0, spawnLocations.Length);

        // instantiate ghost at random spawn location
        Instantiate(ghostPrefab, spawnLocations[ghostIndex].transform.position, ghostPrefab.transform.rotation);
        
    }

}
