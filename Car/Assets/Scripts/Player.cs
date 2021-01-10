using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int maxHP = 5;
    public GameObject lose;
    public GameObject tutorial;
    public GameObject camera;
    public GameObject finish;
    public GameObject pause;
    public static bool resume = true;
    public static int currentHP;
	Rigidbody rb;
	
	void Start () {
        currentHP = maxHP;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            camera.transform.Rotate(0,180,0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (resume == true)
            {
                pause.SetActive(true);
                resume = false;
                Time.timeScale = 0f;
            }
            else if (resume == false)
            {
                pause.SetActive(false);
                resume = true;
                Time.timeScale = 1f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            takeDamage();
        }

        if(other.tag == "Start"){
            tutorial.SetActive(true);
        }

        if (other.tag == "Finish")
        {
            finish.SetActive(true);
            Score.timer = (float)System.Math.Round(Score.timer, 2) ;
            if(Score.timer < PlayerPrefs.GetFloat("BestTime", 0) || PlayerPrefs.GetFloat("BestTime", 0) == 0){
                PlayerPrefs.SetFloat("BestTime", Score.timer);
            }
        }
    }

    public void takeDamage()
    {
        currentHP -= 1;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    public void healHP()
    {
        currentHP += 1;
    }

    public void Die()
    {
        lose.SetActive(true);
        Time.timeScale = 0f;
    }
}
