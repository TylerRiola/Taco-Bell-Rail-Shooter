using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TBRailShooter.Enemy;
using TBRailShooter.Movement;

public class EnemyList : MonoBehaviour
{
    List<Transform> enemies = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< transform.childCount; i++)
        {
            enemies[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.childCount + " " + transform.name);
    }

    public List<Transform> GetEnemyList()
    {
        return enemies;
    }
}
