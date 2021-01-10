using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text bestTime;

    void Update()
    {
        bestTime.text = PlayerPrefs.GetFloat("BestTime").ToString();
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
