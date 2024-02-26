using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SpawnManagerScriptableObject;

public class SlimeSpawner : MonoBehaviour
{
    // The GameObject to instantiate.
    //public GameObject entityToSpawn;

    // An instance of the ScriptableObject defined above.
    public SpawnManagerScriptableObject spawnManagerValues;

    [SerializeField] List<GameObject> spawners;

    // This will be appended to the name of the created entities and increment when each is created.
    int instanceNumber = 1;

    void Start()
    {
        StartCoroutine(Spawn(spawnManagerValues.timeBetweenWaves));

        //SpawnEntities();
    }

    void SpawnEntities()
    {
        int currentSpawnPointIndex = 0;

        Debug.Log("Waves: " + spawnManagerValues.slimeWaves.Count);

        for (int i = 0; i < spawnManagerValues.slimeWaves.Count; i++)
        {
            SlimeWaveScriptableObject currentWave = spawnManagerValues.slimeWaves[i];

            for (i = 0; i < currentWave.GetSlimeCount(); i++)
            {
                Debug.Log("Slimes in wave: " + currentWave.GetSlimeCount());
                Debug.Log("This is slime: " + i);

                // Creates an instance of the prefab at the current spawn point.
                GameObject currentEntity = Instantiate(
                    currentWave.GetSlimeList()[i].slimePrefab,
                    spawners[currentSpawnPointIndex].transform.position,
                    Quaternion.identity);

                // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
                currentEntity.name = currentWave.GetSlimeList()[i].prefabName + instanceNumber;
            }

            // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.slimeWaves.Count;

            instanceNumber++;
        }
    }

    IEnumerator Spawn(int timeBetweenWaves)
    {        
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnManagerValues.slimeWaves.Count; i++){

            SlimeWaveScriptableObject currentWave = spawnManagerValues.slimeWaves[i];

            for (i = 0; i < currentWave.GetSlimeCount(); i++)
            {
                float timeBetweenSpawn = currentWave.spawnFrequencyInSeconds;

                Debug.Log("Slimes in wave: " + currentWave.GetSlimeCount());
                Debug.Log("This is slime: " + i);

                // Creates an instance of the prefab at the current spawn point.
                GameObject currentEntity = Instantiate(
                    currentWave.GetSlimeList()[i].slimePrefab,
                    spawners[currentSpawnPointIndex].transform.position,
                    Quaternion.identity);

                // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
                currentEntity.name = currentWave.GetSlimeList()[i].prefabName + instanceNumber;

                // wait time between spawns.
                yield return new WaitForSeconds(timeBetweenSpawn);
            }

            // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
            //currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.slimeWaves.Count;

            instanceNumber++;

            // wait time between waves.
            yield return new WaitForSeconds(timeBetweenWaves);
        }        
    }
}
