using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject deathFX;
    public float health = 4f;
    public static int EnemiesAlive = 0;

    void Start()
    {
        EnemiesAlive++;
    }
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        // getting the vector 
        Debug.Log(colInfo.relativeVelocity.magnitude);
        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathFX, transform.position, Quaternion.identity);
        EnemiesAlive--;
        if (EnemiesAlive <= 0)
        {
            Debug.Log("LEVEL COMPLETED");
        }
        Destroy(gameObject);
    }
}
