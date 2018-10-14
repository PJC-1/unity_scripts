using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
    void OnTriggerEnter(){
        Debug.Log("Finish");
        // grabs the scene we are in and adds 1 to it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
