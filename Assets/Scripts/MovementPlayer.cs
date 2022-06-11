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
        //Waypoint waypoint;
        //[SerializeField] List<Waypoint> path = new List<Waypoint>();
        //[SerializeField] float waitTime = 10f;
        //[SerializeField] int remainingEnemies = 4;
        //int positionInPath = 0;
       // [SerializeField] bool moveBool = true;
        NavMeshAgent playerNavMesh;


        void Start()
        {
            playerNavMesh = GetComponent<NavMeshAgent>();

            //positionInPath = 1;
            //waypoint = path[positionInPath];
            //SetNextPlayerDestination();
            //remainingEnemies = waypoint.GetRemainingEnemies();
        }
        private void Update()
        {

        }

        //private void SetRemainingEnemies_Base()
        //{
        //    remainingEnemies = 1;
        //}

        //public void SetNextWaypoint()
        //{
        //    positionInPath++;
        //    waypoint = path[positionInPath];
        //    SetNextPlayerDestination();
        //    remainingEnemies = waypoint.GetRemainingEnemies();

        //}
        //public Waypoint GetCurrentWaypont()
        //{
        //    return waypoint;
        //}
        public void SetNextPlayerDestination(Vector3 destination) 
        {
            Debug.Log("Player Destination: " + destination);
            playerNavMesh.destination = destination;
            Debug.Log(playerNavMesh.destination);
        }

        //private void SetRemainingEnemies_Base()
        //{
        //    remainingEnemies = 1;
        //}

        //public void SetNextWaypoint()
        //{
        //    positionInPath++;
        //    waypoint = path[positionInPath];
        //    SetNextPlayerDestination();
        //    remainingEnemies = waypoint.GetRemainingEnemies();

        //}
        //public Waypoint GetCurrentWaypont()
        //{
        //    return waypoint;
        //}

        //public void SetMoveBool()
        //{
        //    moveBool = !moveBool;
        //}
        //public bool GetMoveBool()
        //{
        //    return moveBool;
        //}

        //void OnTriggerStay(Collider other)
        //{
        //    Debug.Log("Enemies Remaining: " + waypoint.GetRemainingEnemies() + " Waypoint: " + positionInPath);
        //    if (other.tag == "Waypoint" && waypoint.GetRemainingEnemies() <= 0)
        //    {
        //        // SetMoveBool();
        //        SetRemainingEnemies_Base();
        //        SetNextWaypoint();
        //    }
        //}
        //void OnTriggerEnter(Collider other)
        //{
        //    if(other.tag == "Waypoint")
        //    {

        //    }

        //}

        //private void OnTriggerStay(Collider other)
        //{
        //    if (other.tag == "Waypoint" && remainingEnemies == 0)
        //    {
        //        SetMoveBool();
        //    }
        //}

        //public void SetNextPosition(Waypoint waypoint)
        //{
        //    playerNavMesh.destination = waypoint.transform.position;
        //}
        //public void SetRemainingEnemies()
        //{
        //    remainingEnemies--;
        //}


        // Update is called once per frame
        //IEnumerator FollowPath()
        //{
        //    foreach(Waypoint waypoint in path)
        //    {
        //        //atPosition = false;
        //        print(atPosition);
        //        if (atPosition == true)
        //        playerNavMesh.destination = waypoint.transform.position;
        //        atPosition = false;

        //        if (playerNavMesh.destination == waypoint.transform.position)
        //        {
        //            print("Stopped?");
        //            yield return new WaitForSeconds(waitTime);
        //            atPosition = true;
        //        }
        //    }
        //}
    }
}
