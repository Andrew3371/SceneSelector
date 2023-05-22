using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILastSceneInfo : MonoBehaviour
{
    [SerializeField]
    Text text_previousSceneLoaded;

    void Start()
    {
        if (ScenesList.SceneToLoadIndex != ScenesList.SceneMainMenuIndex) text_previousSceneLoaded.text = $"Последняя загруженная сцена: \nИндекс: {ScenesList.SceneToLoadIndex}\nНазвание: \"{ScenesList.GetSceneNameByIndex(ScenesList.SceneToLoadIndex)}\"";
        else text_previousSceneLoaded.text = "Последняя загруженная сцена: нет";
    }
}
