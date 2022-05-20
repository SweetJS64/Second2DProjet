using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "CustomIntEvent", menuName = "Events/IntEvent")]
public class IntEvent : ScriptableObject
{
    public UnityAction<int> OnEventRaised;

    public void RaiseEvent(int arg)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(arg);
    }
}
