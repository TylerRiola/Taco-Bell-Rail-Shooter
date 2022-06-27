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
        [SerializeField] List<EnemyHealth> enemies = new List<EnemyHealth>();
        [SerializeField] GameObject lookAtPoint;
        [SerializeField] Cinemachine.CinemachineVirtualCamera c_VirtualCamera;
        [SerializeField] float waypointWait = 2f;
        int remainingEnemies;
        bool cameraBool = false;
        [SerializeField] bool moveBool = false;

        void Start()
        {
            waypoint = GetComponent<Waypoint>();
            ResetRemainingEnemies();

         
            if (enemies.Count > 0)
            { 
            foreach (EnemyHealth enemy in enemies)
            {
                enemy.SetCurrentWaypoint_Enemy(waypoint);
            }
            }
        }

        void Update()
        {
        }
        //Remaining Enemies functions
        public int GetRemainingEnemies()
        {
            return remainingEnemies;
        }
        public void ResetRemainingEnemies()
        {
            remainingEnemies = enemies.Count;
        }
        public void SetRemainingEnemies()
        {
            remainingEnemies--;
        }


        //Set move for enemies
        public void SetWaypointEnemies()
        {
            foreach (EnemyHealth enemy in enemies)
            {
                if (enemy == null) return;
                enemy.SetCurrentWaypoint_Enemy(waypoint);
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
                foreach (EnemyHealth enemy in enemies)
                {
                    enemy.GetComponent<EnemyMovement>().CanMove();
                }
            }
        }

    }
}
