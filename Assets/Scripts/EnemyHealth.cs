using System.Collections;
using System.Collections.Generic;
using TBRailShooter.Movement;
using UnityEngine;

namespace TBRailShooter.Enemy
{
    public class EnemyHealth : MonoBehaviour
    {
        GameObject player;
        MovementPlayer movementPlayer;
        float health = 1;

        // Start is called before the first frame update
        void Start()
        {
            health = 1;
            player = GameObject.FindWithTag("Player");
            movementPlayer = player.GetComponent<MovementPlayer>();
        }

        // Update is called once per frame
        void Update()
        {
           // Debug.Log(waypoint.GetRemainingEnemies() + " " + waypoint.name + " " + gameObject.name);
        }

        private void OnMouseDown()
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
        public float GetEnemyHealth()
        {
            return health;
        }
    }
}