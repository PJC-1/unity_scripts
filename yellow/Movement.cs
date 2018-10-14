using UnityEngine;

public class Movement : MonoBehaviour {
    // grab the rigidbody
    public Rigidbody rb;

    // create a variable that will hold the amount of force being applied
    public float forceApplied = 40f;

    // check to see what key was pressed
    void FixedUpdate() {
        // depending on what key was pressed we need to move in that direction by applying a force
        if(Input.GetKey("w")){
            rb.AddForce(0, 0, forceApplied * Time.deltaTime);
        }

        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -forceApplied * Time.deltaTime);
        }

        if(Input.GetKey("d")){
            rb.AddForce(forceApplied * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a")){
            rb.AddForce( -forceApplied * Time.deltaTime, 0, 0);
        }
    }

}
