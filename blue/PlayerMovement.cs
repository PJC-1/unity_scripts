using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // player speed
    public float speed = 6f;

    // reference the Animator Controller
    private Animator anim;

    // store the movement we want to apply to the player
    private Vector3 movement;

    // reference to the players rigidbody
    private Rigidbody playerRigidbody;

    // execute when the scene loads
    void Awake() {
        // set the player rigid body variable to the player's rigidbody
        playerRigidbody = GetComponent<Rigidbody>();

        // sets animation to be the Animator Controller on the player
        anim = GetComponent<Animator>();
    }

    // fires every physics update
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        // call the functions
        Move(h, v);
        Turning();
        Animating(h, v);
    }

    // create move function
    void Move(float h, float v) {
        // set the movement vector
        movement.Set(h, 0f, v);
        //normalize the vectors so no speed boost is given
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    // create a turn function
    void Turning() {

    }

    // create an animate function
    void Animating(float h, float v) {
        // set walking to true if h or v is not 0
        bool walking = h != 0f || v != 0f;

        // set the Animator Controller condition of IsWalking to true or false
        anim.SetBool("IsWalking", walking);
    }
}
