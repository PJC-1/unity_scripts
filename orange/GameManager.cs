using UnityEngine;

// access scene manager
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log ("Game Over");
            Invoke("Restart", 1f);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
