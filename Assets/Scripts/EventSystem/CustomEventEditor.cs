using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VoidEvent))]
public class CustomEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        VoidEvent gameEvent = (VoidEvent)target;
        if (GUILayout.Button("Raise event"))
        {
            gameEvent.RaiseEvent();
        }
    }
}
