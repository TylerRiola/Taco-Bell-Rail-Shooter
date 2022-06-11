using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Waypoints;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;
using UnityEngine.AI;

namespace TBRailShooter.Core
{

    public class WaypointManager : MonoBehaviour
    {
        Waypoint waypoint;
        [SerializeField] List<Waypoint> path = new List<Waypoint>();
        int positionInPath = 0;
        [SerializeField] bool moveBool = true;
        [SerializeField] GameObject player;
        MovementPlayer movementPlayer;

        void Start()
        {
            movementPlayer = player.GetComponent<MovementPlayer>();
            positionInPath = 1;
            waypoint = path[positionInPath];
            SetNextWaypoint();
           // Debug.Log(positionInPath + " " + movementPlayer);
            Debug.Log(waypoint.transform.position);
            movementPlayer.SetNextPlayerDestination(waypoint.transform.position);
            waypoint.GetRemainingEnemies();

        }

        private void Update()
        {
            
        }

        public void SetNextWaypoint()
        {
            positionInPath++;
            waypoint = path[positionInPath];
        }
        public Waypoint GetCurrentWaypont()
        {
            return waypoint;
        }
    }
}
