using UnityEngine;

public class BlackBall : MonoBehaviour
{
    [SerializeField] VoidEventChannel gateTriggerEventChannel;
    [SerializeField] float lifeTime = 10f;

    void OnEnable()
    {
        gateTriggerEventChannel.AddListener(OnGateTriggered);
    }

    void OnDisable()
    {
        gateTriggerEventChannel.RemoveListener(OnGateTriggered);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out PlayerController player))
        {
            player.OnDefeated();
        }
    }

    void OnGateTriggered()
    {
        Destroy(gameObject, lifeTime);
    }
}