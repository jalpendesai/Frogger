using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour {

    public float spawnDelay = 1.2f;
    public GameObject log;
    public Transform[] LogSpawnPoints;

    float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            Spawnlogs();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void Spawnlogs()
    {
        int randomIndex = Random.Range(0, LogSpawnPoints.Length);
        Transform LogSpawnPoint = LogSpawnPoints[randomIndex];

        Instantiate(log, LogSpawnPoint.position, LogSpawnPoint.rotation);
    }
}

