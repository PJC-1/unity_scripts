using UnityEngine;

public class WorldRotate : MonoBehaviour {
    // grab the world itself
    public GameObject world;

    // determine how fast the world will rotate
    public float speed = 60f;

    // on awake grab the world game object
    void Awake() {
        world = gameObject;
    }

    void FixedUpdate() {
        // get the key press to rotate it right
        if(Input.GetKey("e")) {
            world.transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        // get the key press to rotate it left
        if(Input.GetKey("q")) {
            world.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }
    }

}
