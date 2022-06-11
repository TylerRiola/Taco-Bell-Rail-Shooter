using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;

namespace TBRailShooter.Waypoints
{
    public class Waypoint : MonoBehaviour
    {
        [SerializeField] List<EnemyHealth> enemies = new List<EnemyHealth>();
        int remainingEnemies;
        [SerializeField] bool moveBool = false;
        // Start is called before the first frame update

        void Start()
        {
            ResetRemainingEnemies();
        }

        // Update is called once per frame
        void Update()
        {

        }
        //Remaining Enemies functions
        public int GetRemainingEnemies()
        {
            // return remainingEnemies;
            return 0;
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


    }
}
