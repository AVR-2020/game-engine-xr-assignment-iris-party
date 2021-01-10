using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text health;

    void Update()
    {
        health.text = "Health   " + Player.currentHP;
    }
}
