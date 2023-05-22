using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ������������� ��� �������� ����
public class InitializeAll : MonoBehaviour
{
    [SerializeField]
    Text textAssetInfo;

    public string assetName;
    public string tips; // ����������
    void Awake()
    {
        ScenesList.ScenesCount = SceneManager.sceneCountInBuildSettings; // ����� ���������� ���� � �����
        ScenesList.InitializeScenesNames(SceneManager.sceneCountInBuildSettings);

        textAssetInfo.text = $"����������� �����: \"{assetName}\"\n���������� ���� � �����: {SceneManager.sceneCountInBuildSettings}\n����������: {(tips == string.Empty ? "���" : tips)}.";
    }
}
