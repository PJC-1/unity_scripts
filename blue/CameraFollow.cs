using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Target for the camera to follow
	public Transform target;

	// Want a little bit of lag to follow the player
	public float smoothing = 5f;

	// Store the camera offset
	Vector3 offset;

	// Use this for initialization
	void Start () {

		// This stores the distance between the camera and the player
		offset = transform.position - target.position;
	}

	// Physics update is used not because the camera has physics, but
	// because the player has physics.
	// This way they the camera and player match, where the camera will
	// update as often as the player
	void FixedUpdate () {
		// Find a place for this camera to go
		Vector3 targetCamPos = target.position + offset;

		// The Lerp() will Linearly interpolates between two vectors
		// a smooth transition between the position of our player (transform.position)
		// and where we want the camera to be (targetCamPos).
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

	}
}
