using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHandler : MonoBehaviour {

    private int health = 100;

    public void DoDamage(int damage)
    {
        health -= damage;
        if(health < 0)
        {
            DeathTrigger();
        }
        Debug.Log("Zombie got hit");
    }

    void DeathTrigger()
    {
        Destroy(gameObject);
    }
}
