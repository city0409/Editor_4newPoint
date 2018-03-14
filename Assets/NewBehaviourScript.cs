using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    public List<Vector3> path = new List<Vector3>();

	private void Awake() 
	{
		
	}

#if UNITY_EDITOR
    private void OnDrawGizmos () 
	{
        for (int i = 0; i < path.Count; i++)
        {
            Gizmos.DrawWireSphere(path[i], 0.2f);
        }
	}
#endif
}
