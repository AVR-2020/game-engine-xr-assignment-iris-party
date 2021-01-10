using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject HowtoPlay;
    public GameObject bestTime;

    
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // move to next scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("car");
        Score.timer = 0;
    }

    public void HowtoPLayButton()
    {
        
        MainMenu.SetActive(false);
        HowtoPlay.SetActive(true);
    }
    
    public void BestTime()
    {

        MainMenu.SetActive(false);
        bestTime.SetActive(true);
    }

    public void MainMenuButton()
    {
        
        MainMenu.SetActive(true);
        HowtoPlay.SetActive(false);
        bestTime.SetActive(false);
    }

    public void QuitButton()
    {
        
        Application.Quit();
    }
}