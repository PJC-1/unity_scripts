using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    // player speed
    public float speed = 6f;

    // jump
    public float jumpForce = 10f;
    public bool isGrounded;
    private Vector3 movement; // store the movement we want to apply to the player
    private Rigidbody playerRigidbody; // reference to the players rigidbody

    // execute when the scene loads
    void Awake() {
        // set the player rigid body variable to the player's rigidbody
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // turn is grounded to true when we hit something
    void OnCollisionEnter() {
        isGrounded = true;
    }

    // fires every physics update
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
    }

    void Update() {
        // jump
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            // add some force to player to make them jump
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // we are no longer on the ground
            isGrounded = false;
            // add audio sound effects
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }

        // restart level when player falls
        if(playerRigidbody.position.y < -4f) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
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
