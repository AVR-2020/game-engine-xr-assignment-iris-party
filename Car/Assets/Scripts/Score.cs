using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float timer = 0f;
    public Text score;


    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        score.text = System.Math.Round(Score.timer, 2).ToString();
    }
}
