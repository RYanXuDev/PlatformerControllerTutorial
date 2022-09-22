using UnityEngine;

public class TwoParametersEventChannel<T1, T2> : ScriptableObject
{
    event System.Action<T1, T2> Delegate;

    public void Broadcast(T1 obj1, T2 obj2)
    {
        Delegate?.Invoke(obj1, obj2);
    }

    public void AddListener(System.Action<T1, T2> action)
    {
        Delegate += action;
    }

    public void RemoveListener(System.Action<T1, T2> action)
    {
        Delegate -= action;
    }
}