using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(NewBehaviourScript))]
public class NewBehaviourScriptEditor : Editor 
{

	public void OnSceneGUI() 
	{
        NewBehaviourScript t = (NewBehaviourScript)target;

        for (int i = 0; i < t.path.Count; i++)
        {
            EditorGUI.BeginChangeCheck();

            Vector3 newPoint = UnityEditor.Handles.FreeMoveHandle(t.path[i], Quaternion.identity, 0.5f, new Vector3(.25f, .25f, .25f), Handles.CircleHandleCap);

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Free Move Handle");
                t.path[i] = newPoint;
            }
        }
	}
}
