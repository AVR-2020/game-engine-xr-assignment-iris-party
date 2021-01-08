using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public static int score = 0;
    public GameObject lose;

    public void takeDamage()
    {
        health -= 1;

        if (health <= 0){
            Die();
        }
    }

    public void healHP()
    {
        health += 1;
    }

    public void Die()
    {
        lose.SetActive(true);
    }
}
