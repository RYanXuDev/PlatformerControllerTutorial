using UnityEngine;

public class ThreeParametersEventChannel<T1, T2, T3> : ScriptableObject
{
    event System.Action<T1, T2, T3>  Delegate;

    public void Broadcast(T1 obj1, T2 obj2, T3 obj3)
    {
        Delegate?.Invoke(obj1, obj2, obj3);
    }

    public void AddListener(System.Action<T1, T2, T3>  action)
    {
        Delegate += action;
    }

    public void RemoveListener(System.Action<T1, T2, T3>  action)
    {
        Delegate -= action;
    }
}