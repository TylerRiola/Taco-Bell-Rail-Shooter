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
        Vector3 nextPosition;
        [SerializeField] GameObject player;
        MovementPlayer movementPlayer;

        void Start()
        {
            movementPlayer = player.GetComponent<MovementPlayer>();
            SetNextWaypoint();
            SetPlayer();

        }

        private void Update()
        {
            if(waypoint.GetRemainingEnemies() <= 0 && waypoint.GetMoveBool())
            {
                SetNextWaypoint();
                SetPlayer();
            }
        }

        private void SetPlayer()
        {
            movementPlayer.SetNextPlayerDestination(waypoint.transform.position);
            movementPlayer.SetCurrentWaypoint_Player(waypoint);
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
