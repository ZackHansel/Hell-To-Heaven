using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject tilePrefabs;
    public GameObject referenceObject;
    public float tileLength = 40;
    public float timeOffset = 0.4f;
    public float distanceBetweenTiels = 5.0f;
    public float randomValue = 0.8f;
    private Vector3 previousTilePosition;
    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(-2, 1, 0), otherDirection = new Vector3(0,-1, 2), anotherDirection = new Vector3(2,1, 0), diffrentDirection =new Vector3(0, 1, -2);

    void Start()
    {
        previousTilePosition = referenceObject.transform.position;
        startTime = Time.time;
    }

    // Update is called once per framessss
    void Update()
    {
        if (Time.time - startTime > timeOffset)
        {
            if (Random.value < randomValue)
                direction = mainDirection;
            else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                direction = anotherDirection;
                diffrentDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiels * direction;
            startTime = Time.time;
            Instantiate(tilePrefabs, spawnPos, Quaternion.Euler(0, 0, 0));
            previousTilePosition = spawnPos;
        }
    }
   /* public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward , transform.rotation);
    }*/
}
