using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCollider : MonoBehaviour
{
    GameObject leftPlayer;
    GameObject rightPlayer;
    Collider leftPlayerCollider;
    Collider rightPlayerCollider;

    // Start is called before the first frame update
    void Start()
    {
        leftPlayer = GameObject.FindGameObjectWithTag("LeftPlayer");
        rightPlayer = GameObject.FindGameObjectWithTag("RightPlayer");
        
        leftPlayerCollider = leftPlayer.GetComponent<Collider>();
        rightPlayerCollider = rightPlayer.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    private void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.name == "LeftCapsule")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Collision detected by name.");
            //Destroy(this.gameObject);
        }

        if (other == leftPlayerCollider || other == rightPlayerCollider)
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Collision detected from player collider by trigger");
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "LeftPlayer")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Collision detected by tag.");
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    //Check for a match with the specified name on any GameObject that collides with your GameObject
    //    if (collision.gameObject.name == "LeftCapsule")
    //    {
    //        //If the GameObject's name matches the one you suggest, output this message in the console
    //        Debug.Log("Collision detected by name.");

            
    //    }

    //    if (collision.collider == leftPlayerCollider || collision.collider == rightPlayerCollider)
    //    {
    //        //If the GameObject's name matches the one you suggest, output this message in the console
    //        Debug.Log("Collision detected from player collider");
    //    }

    //    //Check for a match with the specific tag on any GameObject that collides with your GameObject
    //    if (collision.gameObject.tag == "LeftPlayer")
    //    {
    //        //If the GameObject has the same tag as specified, output this message in the console
    //        Debug.Log("Collision detected by tag.");
    //    }
    //}
}
