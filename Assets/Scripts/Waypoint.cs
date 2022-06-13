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
        int remainingEnemies;
        [SerializeField] bool moveBool = false;
        [SerializeField] bool currentWaypoint = false;
        // Start is called before the first frame update

        void Start()
        {
            waypoint = GetComponent<Waypoint>();
            ResetRemainingEnemies();

            //if (lookAtPoint == null) return;
            //else  SetRotation_Waypoint();
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
            if (remainingEnemies <= 0 && !moveBool)
            {
                setCurrentWaypoint();
                SetMoveBool();
            }
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

        //Move Bool functions
        public bool GetMoveBool()
        {
            return moveBool;
        }
        public void SetMoveBool()
        {
            moveBool = !moveBool;
        }


        //Set move for enemies
        public void SetWaypointEnemies()
        {
            foreach (EnemyHealth enemy in enemies)
            {
                enemy.SetCurrentWaypoint_Enemy(waypoint);
            }
        }
        public void setCurrentWaypoint()
        {
            currentWaypoint = !currentWaypoint;
        }
        public bool GetCurrentWaypoint()
        {
            return currentWaypoint;
        }
        public Transform GetLookAt()
        {
            return lookAtPoint.transform;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                setCurrentWaypoint();
                SetWaypointEnemies();
                foreach (EnemyHealth enemy in enemies)
                {
                    enemy.GetComponent<EnemyMovement>().CanMove();
                }
                //Debug.Log(c_VirtualCamera.GetComponent<LookAtObject>())/*.SetLookAtCamera(lookAtPoint)*/;
            }
        }

    }
}
