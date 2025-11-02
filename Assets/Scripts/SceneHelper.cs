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

    public void LoadNextLevel()
    {
        // get the last charcter of the current scene name
        string sceneName = SceneManager.GetActiveScene().name;
        string lastCharacterOfSceneName = sceneName.Substring(sceneName.Length - 1);

        // if it can be parsed into an int, add one to it and load that scene
        if (int.TryParse(lastCharacterOfSceneName, out int levelNumber))
        {
            LoadScene("Level_" + (levelNumber + 1));
        }
        // otherwise, load level 1
        else
        {
            LoadScene("Level_1");
        }
    }
}
