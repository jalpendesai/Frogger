using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {

    public float spawnDelay = .9f;
    public GameObject car;
    public Transform[] SpawnPoints;

    float nextTimeToSpawn = 0f;

    void Start()
    {
        InvokeRepeating("SpawnCars", 0f, 1f); 
    }

    // Update is called once per frame
    /*void Update () {
		if(nextTimeToSpawn <= Time.time)
        {
            SpawnCars();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
	}*/

    void SpawnCars()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);
        Transform SpawnPoint = SpawnPoints[randomIndex];

        Instantiate(car, SpawnPoint.position, SpawnPoint.rotation);
    }
}
