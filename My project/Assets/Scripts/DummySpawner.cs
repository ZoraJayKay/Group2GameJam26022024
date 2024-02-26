using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummySpawner : MonoBehaviour
{
    [SerializeField] GameObject slimePrefab;
    [SerializeField] GameObject player;
    [SerializeField] List<SlimeWaveScriptableObject> slimeWaves;
    [SerializeField] GameManager gameManager;
    [SerializeField] List<GameObject> spawners;

    // Start is called before the first frame update
    void Start()
    {
        spawners = new List<GameObject>();
        spawners.Add(GameObject.FindGameObjectWithTag("LeftPlayer"));
        spawners.Add(GameObject.FindGameObjectWithTag("RightPlayer"));
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouyse button is pressed then toggle which gameobject is selected.
        if (Input.GetMouseButtonDown(1))
        {
            player = gameManager.ReturnCurrentPlayer();
            Instantiate(slimePrefab, this.transform);
        }
    }
}
