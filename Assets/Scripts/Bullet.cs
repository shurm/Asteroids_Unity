﻿using UnityEngine;
using System.Collections;
public class Bullet : MonoBehaviour
{
    public Vector3 thrust;
    public Quaternion heading;
    // Use this for initialization
    void Start ()
    {// travelstraight in the X-axis
        thrust.x = 400.0f;
        // donotpassivelydecelerate
        GetComponent<Rigidbody>().drag = 0;
        // set the direction it will travel in
        GetComponent<Rigidbody>().MoveRotation(heading);
        // apply thrust once, no need to apply it again since
        // it will not decelerate
        GetComponent<Rigidbody>().AddRelativeForce(thrust);
    }

    // Update is called once per frame
    void Update ()
    { //Physics engine handles movement, empty for now.
    }
    void OnCollisionEnter(Collision collision)
    {
        // the Collision contains a lot of info, but it’s the colliding
        // object we’re most interested in.
        Collider collider = collision.collider;
        if ( collider.CompareTag("Asteroid") )
        {
            Asteroid roid= collider.gameObject.GetComponent<Asteroid >();
            // let the other object handle its own death throes
            roid.Die();

            // Destroy the Bullet which collided with the Asteroid
            Destroy(gameObject);
        }
        else
        {
            // if we collided with something else, print to console
            // what the other thing was
            Debug.Log ("Collided with " + collider.tag);
        }
    }

    void OnBecameInvisible()
    {
        //Debug.Log("off screen");
        Destroy(gameObject);
    }
}