using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] VoidEventChannel levelClearedEventChannel;
    
    void OnEnable()
    {
        levelClearedEventChannel.AddListener(ShowUI);
    }

    void OnDisable()
    {
        levelClearedEventChannel.RemoveListener(ShowUI);
    }

    void ShowUI()
    {
        GetComponent<Canvas>().enabled = true;
        GetComponent<Animator>().enabled = true;
    }
}