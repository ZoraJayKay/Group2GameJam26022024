using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    GameObject currentObject;

    // Start is called before the first frame update
    void Start()
    {
        // Start the game with the first gameobject selected.
        currentObject = gameObjects[0];
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouyse button is pressed then toggle which gameobject is selected.
        if (Input.GetMouseButtonDown(0))
        {
            if (currentObject == gameObjects[0])
            {
                currentObject = gameObjects[1];
            }

            else currentObject = gameObjects[0];
        }

        currentObject.gameObject.transform.Rotate(Vector3.back);
    }
}
