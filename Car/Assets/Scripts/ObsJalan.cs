using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsJalan : MonoBehaviour
{

    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().takeDamage();
        }
    }
    
}
