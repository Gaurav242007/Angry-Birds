using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemyInterval = 10f;
    public Transform[] spawnPoints;
    public Transform EnemyParent;


    void Start()
    {
        StartCoroutine(LoadEnemy());
    }

    IEnumerator LoadEnemy()
    {
        foreach (Transform enemy in spawnPoints)
        {
            yield return new WaitForSeconds(enemyInterval);
            Instantiate(enemyPrefab, enemy.position, Quaternion.identity, EnemyParent.transform);
            if (enemyInterval <= 5)
                enemyInterval -= .1f;
        }
    }
}
