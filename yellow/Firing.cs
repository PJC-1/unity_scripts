using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {

  // variables
  // get the rigid body component of the player
  public Rigidbody rb;

  // create a variable to hold our force amount
  public float forwardForce = 2000f;

	// Update is called once per physics update
	void FixedUpdate() {
		// fire the ball with a key press
        if(Input.GetKey("space")){
            // move the ball forward
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
	}
}
