using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // grab the rigidbody
    public Rigidbody rb;

    // create a variable that will hold the amount of force being applied
    public float forceApplied = 100f;

    public float forwardForce = 1000f;

    // check to see what key was pressed
    void FixedUpdate() {
        // what key did the user press?
        // move forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) {
            rb.AddForce(forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")) {
            rb.AddForce( -forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame ();
        }
    }
}
