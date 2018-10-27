using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    // player speed
    public float speed = 6f;

    // jump
    public float jumpForce = 3f;
    public bool isGrounded;
    private Vector3 movement; // store the movement we want to apply to the player
    private Rigidbody playerRigidbody; // reference to the players rigidbody

}
