using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailShooterPath : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnDrawGizmos()
    {
        const float waypointGizmoRadius = 0.3f;
        for(int i = 0; i < transform.childCount; i++)
        {
            Gizmos.DrawSphere(transform.GetChild(i).position, waypointGizmoRadius);
            if(i != transform.childCount-1)
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i+1).position);
                
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
