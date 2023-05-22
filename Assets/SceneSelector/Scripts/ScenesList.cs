using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ScenesList 
{
    static int sceneToLoadIndex = 0;
    static bool isSceneListInitialized = false; // дл€ предотвращени€ повторного вызова метода ListScenesNames()
    static List<string> scenesNames;

    public static int SceneToLoadIndex
    {
        get { return sceneToLoadIndex; }
    }
    public static void SetSceneToLoadIndex(int i)
    {
        sceneToLoadIndex = i;
    }
    public static void SetSceneToLoadIndexDropdown(int i) // fix дл€ Dropdown. ¬ dropdown мы скрываем сцену "0" - главное меню. —оотв. dropdown[0] == общее„исло—цен¬Ѕилде[1].
    {
        sceneToLoadIndex = i + 1;
    }

    static int sceneMainMenuIndex = 0;
    public static int SceneMainMenuIndex
    {
        get { return sceneMainMenuIndex; }
    }

    static int scenesCount = 0;
    public static int ScenesCount
    {
        get { return scenesCount; }
        set { scenesCount = value; }
    }

    static string NameFromIndex(int BuildIndex)
    {
        string path = SceneUtility.GetScenePathByBuildIndex(BuildIndex);
        int slash = path.LastIndexOf('/');
        string name = path.Substring(slash + 1);
        int dot = name.LastIndexOf('.');
        return name.Substring(0, dot);
    }

    // ¬ызываетс€ один раз в начале игры.
    public static void InitializeScenesNames(int scenesCount)
    {
        if (isSceneListInitialized) return;

        scenesNames = new List<string>(scenesCount);
        for(int i = 0; i < scenesCount; i++)
        {
            scenesNames.Add(NameFromIndex(i));
        }

        isSceneListInitialized = true;
    }

    public static string GetSceneNameByIndex(int i)
    {
        return scenesNames[i];
    }
}
