using System;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] VoidEventChannel levelClearedEventChannel;

    [SerializeField] StringEventChannel clearTimeTextEventChannel;

    [SerializeField] Button nextLevelButton;

    [SerializeField] Text timeText;
    
    void OnEnable()
    {
        levelClearedEventChannel.AddListener(ShowUI);
        clearTimeTextEventChannel.AddListener(SetTimeText);

        nextLevelButton.onClick.AddListener(SceneLoader.LoadNextScene);
    }

    void OnDisable()
    {
        levelClearedEventChannel.RemoveListener(ShowUI);
        clearTimeTextEventChannel.RemoveListener(SetTimeText);

        nextLevelButton.onClick.RemoveListener(SceneLoader.LoadNextScene);
    }

    void ShowUI()
    {
        GetComponent<Canvas>().enabled = true;
        GetComponent<Animator>().enabled = true;

        Cursor.lockState = CursorLockMode.None;
    }
    
    void SetTimeText(string obj)
    {
        timeText.text = obj;
    }
}