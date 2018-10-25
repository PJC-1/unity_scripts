using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // get the z position of the player
    public Transform player;
    // get the UI text
    public Text scoreText;


	// Update is called once per frame
	void Update() {
		// update the score text with the z position of the player
        scoreText.text = player.position.z.ToString("0");
	}
}
