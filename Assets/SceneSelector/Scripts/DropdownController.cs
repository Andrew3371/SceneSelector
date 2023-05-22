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
            dropdown.options.Add(new Dropdown.OptionData() { text = $"Cцена: {i.ToString()} \"{ScenesList.GetSceneNameByIndex(i)}\"" });
        }
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        UpdateUI();
        //dropdown.value = dropdown.value = 1; // костыль. Пустое меню dropdown на старте сцены, пока не сделаешь выбор.
        //dropdown.value = dropdown.value = 0; // с ним ломается показ последней загруженной сцены
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        sceneLoader.SetSceneIndexDropdown(dropdown.value);
        UpdateUI();
    }
    void UpdateUI()
    {
        text_selectedSceneInfo.text = $"Выбрана сцена: \nИндекс: {ScenesList.SceneToLoadIndex}\nНазвание: \"{ScenesList.GetSceneNameByIndex(ScenesList.SceneToLoadIndex)}\"";
    }
}
