using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;

namespace TBRailShooter.Waypoints
{
    public class Waypoint : MonoBehaviour
    {
        // [SerializeField] int remainingEnemies = 1;
        [SerializeField] List<EnemyHealth> enemies = new List<EnemyHealth>();
        MovementPlayer movementPlayer ;
        int remainingEnemies;
        // Start is called before the first frame update

        void Start()
        {
            ResetRemainingEnemies();
            //Debug.Log(remainingEnemies);
        }

        // Update is called once per frame
        void Update()
        {
           // Debug.Log(enemies.Count);
        }
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

    }
}
