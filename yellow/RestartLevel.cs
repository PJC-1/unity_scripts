using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// access scene manager
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// get input from the user
        if(Input.GetKey("r")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // reload the current scene
	}
}
