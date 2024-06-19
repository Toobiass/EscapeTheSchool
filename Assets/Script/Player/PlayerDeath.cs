using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Transform enemy;  
    public float deathDistance = 5f;  

    private bool isDead = false;  // Zustand des Spielers

    void Update()
    {
        if (isDead)
            return;
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);
        if (distanceToEnemy <= deathDistance)
        {
            Die();
        }
    }
    void Die()
    {
        isDead = true;
        Debug.Log("Player is dead!");
        gameObject.SetActive(false);
    }
}

