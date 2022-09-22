using UnityEngine;
using UnityEngine.UI;

public class ClearTimer : MonoBehaviour
{
    [SerializeField] Text timeText;
    
    [SerializeField] VoidEventChannel levelStartedEventChannel;
    [SerializeField] VoidEventChannel levelClearedEventChannel;
    [SerializeField] VoidEventChannel playerDefeatedEventChannel;

    [SerializeField] StringEventChannel clearTimeTextEventChannel;

    bool stop = true;

    float clearTime;

    void OnEnable()
    {
        levelStartedEventChannel.AddListener(LevelStart);
        levelClearedEventChannel.AddListener(LevelClear);
        playerDefeatedEventChannel.AddListener(HideUI);
    }

    void OnDisable()
    {
        levelStartedEventChannel.RemoveListener(LevelStart);
        levelClearedEventChannel.RemoveListener(LevelClear);
        playerDefeatedEventChannel.RemoveListener(HideUI);
    }

    void FixedUpdate()
    {
        if (stop) return;

        clearTime += Time.fixedDeltaTime;
        timeText.text = System.TimeSpan.FromSeconds(clearTime).ToString(@"mm\:ss\:ff");
    }

    void LevelStart()
    {
        stop = false;
    }
    
    void LevelClear()
    {
        HideUI();
        clearTimeTextEventChannel.Broadcast(timeText.text);
    }

    void HideUI()
    {
        stop = true;
        GetComponent<Canvas>().enabled = false;
    }
}