using System.Collections;
using System.Collections.Generic;
using TBRailShooter.Movement;
using TBRailShooter.Waypoints;
using UnityEngine;

namespace TBRailShooter.Enemy
{
    public class EnemyHealth : MonoBehaviour
    {
        Waypoint waypoint;
        GameObject player;
        MovementPlayer movementPlayer;
        float health = 1;

        // Start is called before the first frame update
        void Start()
        {
            health = 1;
            player = GameObject.FindWithTag("Player");
            movementPlayer = player.GetComponent<MovementPlayer>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnMouseDown()
        {
            health--;
            if (health <= 0)
            {
                waypoint.SetRemainingEnemies();
                Debug.Log(waypoint.GetRemainingEnemies());
                Destroy(gameObject);
            }
        }
        public float GetEnemyHealth()
        {
            return health;
        }
        public void SetCurrentWaypoint_Enemy(Waypoint waypoint)
        {
            this.waypoint = waypoint;
        }
    }
}