using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneToLoadIndex = 0;
    public void SetSceneIndex(int i)
    {
        ScenesList.SetSceneToLoadIndex(i);
    }
    public void SetSceneIndexDropdown(int i)
    {
        ScenesList.SetSceneToLoadIndexDropdown(i);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(ScenesList.SceneToLoadIndex);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(ScenesList.SceneMainMenuIndex);
    }
}
