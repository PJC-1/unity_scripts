using UnityEngine;

public class ColorChanger : MonoBehaviour {
    // Check for collision
    void OnCollisionEnter(Collision other) {
        // When collision happens do this stuff
        Debug.Log("Contact was made");
        transform.GetComponent<Renderer>().material.color = Color.blue;
    }
}
