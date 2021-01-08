using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsJalan : MonoBehaviour
{

    Player player;

    private void OnTriggerEnter(Collider other)
    {
            player.takeDamage();

    }
    
}
