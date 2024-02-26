using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummySpawner : MonoBehaviour
{
    [SerializeField] GameObject slimePrefab;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouyse button is pressed then toggle which gameobject is selected.
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(slimePrefab, this.transform);
        }


    }
}
