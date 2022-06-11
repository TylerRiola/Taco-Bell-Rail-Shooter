using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TBRailShooter.Waypoints;
using TBRailShooter.Enemy;
using System;

namespace TBRailShooter.Movement
{
    public class MovementPlayer : MonoBehaviour
    {
        NavMeshAgent playerNavMesh;
        Vector3 nextDesination;

        void Start()
        {
            playerNavMesh = GetComponent<NavMeshAgent>();
            //nextDesination = playerNavMesh.destination;
            //Debug.Log(playerNavMesh.destination);
           // SetNextPlayerDestination(nextDesination);
        }

        private void Update()
        {
        }

        public void SetNextPlayerDestination(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
            Debug.Log(destination);
            //playerNavMesh.destination = destination;
        }
    }
}
