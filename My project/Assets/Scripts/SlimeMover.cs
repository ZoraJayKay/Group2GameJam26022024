using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3.down * 0.005f);
    }
}
