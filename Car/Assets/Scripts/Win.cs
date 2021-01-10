using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Text time;
    public GameObject pause;

    void Update()
    {
        Score.timer = (float)System.Math.Round(Score.timer, 2);
        time.text = "Your time is " + Score.timer;
        Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("car");
        Score.timer = 0;
        Time.timeScale = 1f;
    }

    public void Return()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
        Player.resume = true;
    }
}
