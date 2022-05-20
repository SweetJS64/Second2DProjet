using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class IntEventListener : MonoBehaviour
{
    [SerializeField]
    private IntEvent _channel = default;

    public UnityEvent<int> OnEventRaised;

    private void OnEnable()
    {
        if (_channel != null)
        {
            _channel.OnEventRaised += Respond;
        }
    }

    private void OnDisable()
    {
        if (_channel != null)
        {
            _channel.OnEventRaised -= Respond;
        }
    }

    private void Respond(int arg)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(arg);
        }
    }
}
