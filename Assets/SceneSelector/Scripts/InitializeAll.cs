using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// инициализатор для главного меню
public class InitializeAll : MonoBehaviour
{
    [SerializeField]
    Text textAssetInfo;

    public string assetName;
    public string tips; // примечания
    void Awake()
    {
        ScenesList.ScenesCount = SceneManager.sceneCountInBuildSettings; // общее количество сцен в билде
        ScenesList.InitializeScenesNames(SceneManager.sceneCountInBuildSettings);

        textAssetInfo.text = $"Тестируемый ассет: \"{assetName}\"\nКоличество сцен в билде: {SceneManager.sceneCountInBuildSettings}\nПримечания: {(tips == string.Empty ? "нет" : tips)}.";
    }
}
