using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float SpawnRate = 5f;
    private float nextSpawnTime = 0f;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] objectsToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            nextSpawnTime = SpawnRate + nextSpawnTime;
            //Instantiate(coinPrefab, transform.position, transform.rotation); // metotlaþtýrdýk kodda esneklik olmasý için 

            Olustur(objectsToSpawn[GetObjectToSpawn()], spawnPositions[GetSpawnPosition()]); 
        }
    }
    private void Olustur(GameObject Player,Transform NewTransform)
    {
        Instantiate(Player, NewTransform.position,NewTransform.rotation);

    }
    private int GetSpawnPosition()
    {
        return Random.Range(0, spawnPositions.Length);
    }
    private int GetObjectToSpawn()
    {
        return Random.Range(0, objectsToSpawn.Length);
    }

}
