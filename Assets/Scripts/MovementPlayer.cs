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
        Waypoint waypoint;
        [SerializeField] List<Waypoint> path = new List<Waypoint>();
        [SerializeField] float waitTime = 10f;
        [SerializeField] int remainingEnemies = 4;
        int positionInPath = 0;
        [SerializeField] bool moveBool = true;
        NavMeshAgent playerNavMesh;


        void Start()
        {
            playerNavMesh = GetComponent<NavMeshAgent>();

            //Debug.Log(GetComponent<EnemyHealth>());
            positionInPath = 1;
            waypoint = path[positionInPath];
            playerNavMesh.destination = path[positionInPath].transform.position;
            remainingEnemies = waypoint.GetRemainingEnemies();
            //Debug.Log(waypoint.GetRemainingEnemies());
            //SetMoveBool();
            // StartCoroutine(FollowPath());

            //remainingEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        }

        private void Update()
        {
            //if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
            //{
            //    SetMoveBool();
            //    SetRemainingEnemies_Base();
            //}
            //if (moveBool)
            //{
            //    SetMoveBool();
            //    SetNextWaypoint();
            //    //Debug.Log(waypoint.GetRemainingEnemies());
            //    //SetMoveBool();
            //}
        }

        private void SetRemainingEnemies_Base()
        {
            remainingEnemies = 1;
        }

        public void SetNextWaypoint()
        {
            positionInPath++;
            waypoint = path[positionInPath];
            playerNavMesh.destination = path[positionInPath].transform.position;
            remainingEnemies = waypoint.GetRemainingEnemies();

        }
        public Waypoint GetCurrentWaypont()
        {
            return waypoint;
        }


        //public void SetMoveBool()
        //{
        //    moveBool = !moveBool;
        //}
        //public bool GetMoveBool()
        //{
        //    return moveBool;
        //}

        void OnTriggerStay(Collider other)
        {
            Debug.Log("Enemies Remaining: " + waypoint.GetRemainingEnemies() + " Waypoint: " + positionInPath);
            if (other.tag == "Waypoint" && waypoint.GetRemainingEnemies() <= 0)
            {
                   // SetMoveBool();
                    SetRemainingEnemies_Base();
                    SetNextWaypoint();
            }
        }
        void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Waypoint")
            {

            }

        }

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
