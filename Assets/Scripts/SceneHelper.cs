using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    // load a scene with the given name
    public void LoadScene(string sceneName)
    {
        Debug.Log("scene Loaded");
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
    }

    // load the scene that is currently loaded, resetting it
    public void ReloadScene()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }
}
