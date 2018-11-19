using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    // player speed
    public float speed = 6f;

    private Vector3 movement; // store the movement we want to apply to the player
    private Rigidbody playerRigidbody; // reference to the players rigidbody

    // execute when the scene loads
    void Awake() {
        // set the player rigid body variable to the player's rigidbody
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // fires every physics update
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
    }

    // create move function
    void Move(float h, float v) {
        // set the movement vector
        movement.Set(h, 0f, v);
        //normalize the vectors so no speed boost is given
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

}
