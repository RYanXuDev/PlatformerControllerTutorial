using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] VoidEventChannel gateTriggeredEventChannel;

    void OnEnable()
    {
        gateTriggeredEventChannel.AddListener(Open);
    }

    void OnDisable()
    {
        gateTriggeredEventChannel.RemoveListener(Open);
    }

    void Open()
    {
        Destroy(gameObject);
    }
}