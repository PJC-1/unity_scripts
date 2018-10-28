using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    // amount of force applied to rigidbody
    public float forceApplied = 20f;

    // holds rigidbody
    public Rigidbody rb;

    // function that updates every physics updates
    // "Fixed" will update every physics update, rather than every frame
    // "void" is used when the function does not return anything
    void FixedUpdate() {
      //Get input from the user
      if(Input.GetKey("w")) {
        //Apply force to rigidbody
        rb.AddForce(0,0, forceApplied * Time.deltaTime);
      }
    }
}
