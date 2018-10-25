using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // get a reference to movement script
    public PlayerMovement movement;

    // fires whenever collision happens
    void OnCollisionEnter(Collision collisionInfo) {
        // fire some script only when the player hits an obstacle
        if(collisionInfo.collider.tag == "Obstacle"){
            // stop player movement
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
