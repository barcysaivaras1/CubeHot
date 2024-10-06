
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;

    Boolean gameHasEnded = false;
    public float restartDelay = 1f;

    public void CompleteLevel() {
        Debug.Log("YOu WIN!");
       completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded) {
            Debug.Log("Game Over");
            gameHasEnded = true;

            //Restart the game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
