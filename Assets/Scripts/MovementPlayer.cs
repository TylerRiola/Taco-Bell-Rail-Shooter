using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TBRailShooter.Enemy;
using TBRailShooter.Waypoints;
using System;

namespace TBRailShooter.Movement
{
    public class MovementPlayer : MonoBehaviour
    {
        Waypoint waypoint;
        NavMeshAgent playerNavMesh;
        Vector3 nextDesination;

        void Start()
        {
            playerNavMesh = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
        }

        public void SetNextPlayerDestination(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }
        public void SetCurrentWaypoint_Player(Waypoint waypoint)
        {
            this.waypoint = waypoint;
            Debug.Log(this.waypoint);
        }
        private void OnTriggerStay(Collider other)
        {
            if(other.gameObject.CompareTag("Waypoint"))
            {

            }
        }
    }
}
