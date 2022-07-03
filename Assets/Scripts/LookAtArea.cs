using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtArea : MonoBehaviour
{
    EnemyList enemyList;
    // Start is called before the first frame update
    void Start()
    {
        enemyList = GetComponentInChildren<EnemyList>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float GetEnemyCountInList()
    {
        ////if (enemyList.GetEnemyCountInList() == 0) return 0;
        ////return enemyList.GetEnemyCountInList();
       // Debug.Log(transform.childCount);
        return transform.childCount;
    }
    public List<Transform> GetEnemyList()
    {
        return enemyList.GetEnemyList();
    }

}
