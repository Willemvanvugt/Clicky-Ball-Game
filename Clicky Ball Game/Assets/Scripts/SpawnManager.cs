using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject sphere;

    public float rangeX;
    public float minRangeY;
    public float maxRangeY;
    public float rangeZ;

    public float delay;
    public float interval;

    private void Start()
    {
        InvokeRepeating("SpawnSpheres", delay, interval);
    }

    void SpawnSpheres()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-rangeX, rangeX), Random.Range(minRangeY, maxRangeY), Random.Range(-rangeZ, rangeZ));
        Instantiate(sphere, spawnPosition, transform.rotation);
        Debug.Log("SpawnShere function was called");
    }
}
