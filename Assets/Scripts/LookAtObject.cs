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
        [SerializeField] Transform target;

        // Start is called before the first frame update
        void Start()
        {
            c_VirtualCamera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void SetLookAtCamera(GameObject lookAt)
        {

        }
    }
}
