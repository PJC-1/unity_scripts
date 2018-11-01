using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
    void OnTriggerEnter() {
        Debug.Log("Checkpoint reached");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
