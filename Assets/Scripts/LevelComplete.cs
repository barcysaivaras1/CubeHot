
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel()
    {
        Debug.Log("Level Loaded");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
