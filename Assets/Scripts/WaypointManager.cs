using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Waypoints;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;
using TBRailShooter.Camera;

namespace TBRailShooter.Core
{

    public class WaypointManager : MonoBehaviour
    {
        Waypoint waypoint;
        [SerializeField] RailShooterPath railShooterPath;
        int positionInPath = 0;
        Vector3 nextPosition;
        [SerializeField] GameObject player;
        [SerializeField] Cinemachine.CinemachineVirtualCamera virtualCamera;
        Transform lookAt;
        MovementPlayer movementPlayer;
        LookAtObject lookAtObject;

        void Start()
        {
            lookAt = null;
            movementPlayer = player.GetComponent<MovementPlayer>();
            SetNextWaypoint();
            SetPlayerAndEnemies();
            
        }

        private void Update()
        {
           // Debug.Log(transform.name + " " + waypoint.GetRemainingEnemies());
            if(waypoint.GetRemainingEnemies() <= 0 && waypoint.GetMoveBool())
            {
                SetNextWaypoint();
                SetPlayerAndEnemies();
                virtualCamera.GetComponent<LookAtObject>().SetLookAtCameraOrigin();
            }
            if (waypoint.GetCameraBool())
            {
                virtualCamera.GetComponent<LookAtObject>().SetLookAtCamera(lookAt);
            }
        }

        private void SetPlayerAndEnemies()
        {
           movementPlayer.SetNextPlayerDestination(waypoint.transform.position);
           movementPlayer.SetCurrentWaypoint_Player(waypoint);
           lookAt = waypoint.GetLookAt();
        }

        public void SetNextWaypoint()
        {
            waypoint = railShooterPath.GetWaypoint(positionInPath).GetComponent<Waypoint>();
            positionInPath++;
           // waypoint.ResetRemainingEnemies();
        }
        public Waypoint GetCurrentWaypont()
        {
            return waypoint;
        }
    }
}
