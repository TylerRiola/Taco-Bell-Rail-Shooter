using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Waypoints;

namespace TBRailShooter.Movement 
{
    public class RailShooterPath : MonoBehaviour
    {
        // Start is called before the first frame update

        public void OnDrawGizmos()
        {
            const float waypointGizmoRadius = 0.3f;
            for (int i = 0; i < transform.childCount; i++)
            {
                Gizmos.DrawSphere(transform.GetChild(i).position, waypointGizmoRadius);
                if (i != transform.childCount - 1)
                {
                    Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
                }

            }
        }

        public int GetNextIndex(int i)
        {
            if (i + 1 == transform.childCount)
                return 0;

            return i + 1;
        }
        public GameObject GetWaypoint(int i)
        {
            return transform.GetChild(i).gameObject;
        }
        void Start()
        {
            GetComponentInChildren<Waypoint>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
