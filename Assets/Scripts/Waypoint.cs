using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;

namespace TBRailShooter.Waypoints
{
    public class Waypoint : MonoBehaviour
    {
        Waypoint waypoint;
        [SerializeField] List<EnemyHealth> enemies = new List<EnemyHealth>();
        int remainingEnemies;
        [SerializeField] bool moveBool = false;
        // Start is called before the first frame update

        void Start()
        {
            waypoint = GetComponent<Waypoint>();
            ResetRemainingEnemies();
            foreach (EnemyHealth enemy in enemies)
            {
                enemy.SetCurrentWaypoint_Enemy(waypoint);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(remainingEnemies <=0 && !moveBool)
            {
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

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                waypoint.SetWaypointEnemies();
                foreach (EnemyHealth enemy in enemies)
                {
                    enemy.GetComponent<EnemyMovement>().CanMove();
                }
            }
        }

    }
}
