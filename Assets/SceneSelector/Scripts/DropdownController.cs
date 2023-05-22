using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropdownController : MonoBehaviour
{
    Dropdown dropdown;
    public Text text_selectedSceneInfo;
    List<string> dropdownOptions = new List<string>(ScenesList.ScenesCount);

    public SceneLoader sceneLoader;
    void Start()
    {
        dropdown = gameObject.GetComponent<Dropdown>();
        dropdown.options.Clear();

        for(int i = 1; i < ScenesList.ScenesCount; i++)
        {
            dropdownOptions.Add(i.ToString());
            dropdown.options.Add(new Dropdown.OptionData() { text = $"C����: {i.ToString()} \"{ScenesList.GetSceneNameByIndex(i)}\"" });
        }
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        UpdateUI();
        //dropdown.value = dropdown.value = 1; // �������. ������ ���� dropdown �� ������ �����, ���� �� �������� �����.
        //dropdown.value = dropdown.value = 0; // � ��� �������� ����� ��������� ����������� �����
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        sceneLoader.SetSceneIndexDropdown(dropdown.value);
        UpdateUI();
    }
    void UpdateUI()
    {
        text_selectedSceneInfo.text = $"������� �����: \n������: {ScenesList.SceneToLoadIndex}\n��������: \"{ScenesList.GetSceneNameByIndex(ScenesList.SceneToLoadIndex)}\"";
    }
}
