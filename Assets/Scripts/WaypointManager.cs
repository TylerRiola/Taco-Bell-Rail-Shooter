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
        //MovementPlayer player;

        void Start()
        {
            positionInPath = 0;
            waypoint = path[positionInPath];
            SetNextWaypoint();
            //player.SetNextPosition(waypoint);
            Debug.Log(waypoint.transform.position);
            
        }

        private void Update()
        {
            if (moveBool)
            {
                SetNextWaypoint();

                //player.SetMoveBool();
            }

            Debug.Log(path.Count);
            if(GetComponent<MovementPlayer>() == null)
            {
                print("This is null!");
            }
            
        }

        public void SetNextWaypoint()
        {
            positionInPath++;
            waypoint = path[positionInPath];
           // remainingEnemies = waypoint.GetRemainingEnemies();
        }
        public Waypoint GetCurrentWaypont()
        {
            return waypoint;
        }
    }
}
