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
        float attackRange = 10f;
        bool canMove = false;
        // Start is called before the first frame update
        void Start()
        {
            //player = GameObject.FindWithTag("Player");
            //movementPlayer = player.GetComponent<MovementPlayer>();
            //playerNavMesh = movementPlayer.GetNavMeshAgent();
            enemyNavMesh = GetComponent<NavMeshAgent>();

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(player.transform.position);
            if (canMove && !GetIsInRange())
            {
                MoveToPlayer();
            }
        }
        public void MoveToPlayer()
        {
            Debug.Log("Moving!");
            enemyNavMesh.destination = GetComponent<EnemyHealth>().GetEnemyDestination();
        }
        private bool GetIsInRange()
        {
            Debug.Log("Is in range!");
            return Vector3.Distance(transform.position, GetComponent<EnemyHealth>().GetEnemyDestination()) < attackRange;
        }
        public void CanMove()
        {
            Debug.Log("Can Move");
            canMove = true;
        }
    }
}
