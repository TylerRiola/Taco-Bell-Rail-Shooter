using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;
using TBRailShooter.Camera;

namespace TBRailShooter.Waypoints
{
    public class Waypoint : MonoBehaviour
    {
        Waypoint waypoint;
        List<Transform> enemies = new List<Transform>();
        GameObject lookAtPoint;
        Cinemachine.CinemachineVirtualCamera c_VirtualCamera;
        [SerializeField] float waypointWait = 2f;
        bool moveBool = false;
        int remainingEnemies;
        bool cameraBool = false;
        

        void Start()
        {
            waypoint = GetComponent<Waypoint>();
            lookAtPoint = GetComponentInChildren<LookAtArea>().gameObject;
            c_VirtualCamera = FindObjectOfType<Cinemachine.CinemachineVirtualCamera>();
           // ResetRemainingEnemies();
            if (GetComponentInChildren<LookAtArea>().GetEnemyList() != null)
            {
                enemies = GetComponentInChildren<EnemyList>().GetEnemyList();

            }

            if (enemies.Count > 0)
            {
                foreach (Transform enemy in enemies)
                {
                    if(enemy != null)
                        enemy.GetComponent<EnemyHealth>().SetCurrentWaypoint_Enemy(waypoint);
                }
            }
        }

        void Update()
        {
        }
        //Remaining Enemies functions
        public float GetRemainingEnemies()
        {
            //return remainingEnemies;
            if (GetComponentInChildren<LookAtArea>().GetComponentsInChildren<EnemyList>() == null) return 0;
            return GetComponentInChildren<LookAtArea>().GetEnemyCountInList();
        }
        //public void ResetRemainingEnemies()
        //{
        //    remainingEnemies = enemies.Count;
        //}
        public void SetRemainingEnemies()
        {
            remainingEnemies--;
        }


        //Set move for enemies
        public void SetWaypointEnemies()
        {
            foreach (Transform enemy in enemies)
            {
                if (enemy == null) return;
                enemy.GetComponent<EnemyHealth>().SetCurrentWaypoint_Enemy(waypoint);
            }
        }
        public Transform GetLookAt()
        {
            return lookAtPoint.transform;
        }
        public bool GetCameraBool()
        {
            return cameraBool;
        }
        public bool GetMoveBool()
        {
            return moveBool;
        }
   
            

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                SetWaypointEnemies();
                cameraBool = !cameraBool;
                moveBool = !moveBool;
                foreach (Transform enemy in enemies)
                {
                    if (enemy != null)
                        enemy.GetComponent<EnemyMovement>().CanMove();
                }
            }
        }

    }
}
