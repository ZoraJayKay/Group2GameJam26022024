using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SlimeWaveScriptableObject", order = 2)]
public class SlimeWaveScriptableObject : ScriptableObject
{
    public float spawnFrequencyInSeconds;

    [SerializeField] List<SlimeScriptableObject> slimesToSpawn;

    public List<SlimeScriptableObject> GetSlimeList()
    {
        return slimesToSpawn;
    }

    public int GetSlimeCount()
    {
        return slimesToSpawn.Count;
    }
}