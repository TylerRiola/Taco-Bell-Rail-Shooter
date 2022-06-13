using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TBRailShooter.Movement;
using TBRailShooter.Enemy;

namespace TBRailShooter.Movement
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] GameObject player;
       // NavMeshAgent playerNavMesh;
        NavMeshAgent enemyNavMesh;
        MovementPlayer movementPlayer;
        float attackRange = 2f;
        bool canMove = false;
        // Start is called before the first frame update 
        void Start()
        {
            enemyNavMesh = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameObject == null) return;
            if (canMove && !GetIsInRange())
            {
                MoveToPlayer();
            }
            else 
            {
                enemyNavMesh.isStopped = true;
            }
        }
        public void MoveToPlayer()
        {
            enemyNavMesh.isStopped = false;
            enemyNavMesh.destination = GetComponent<EnemyHealth>().GetEnemyDestination();
        }
        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, GetComponent<EnemyHealth>().GetEnemyDestination()) < attackRange;
        }
        public void CanMove()
        {
            canMove = true;
        }
    }
}
