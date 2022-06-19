using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Waypoints;
using TBRailShooter.Movement;

namespace TBRailShooter.Camera
{
    public class LookAtObject : MonoBehaviour
    {
        Cinemachine.CinemachineVirtualCamera c_VirtualCamera;
        Transform playerLookAt;

        // Start is called before the first frame update
        void Start()
        {
            c_VirtualCamera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
            playerLookAt = c_VirtualCamera.m_LookAt;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void SetLookAtCamera(Transform lookAt)
        {
            if (lookAt != null)
            //Debug.Log(lookAt.position);
            c_VirtualCamera.m_LookAt = lookAt;
        }
       public void SetLookAtCameraOrigin()
        {
            c_VirtualCamera.m_LookAt = playerLookAt;
        }
        public void SetWaypoint_Camera(Waypoint waypoint)
        {

        }
    }
}
