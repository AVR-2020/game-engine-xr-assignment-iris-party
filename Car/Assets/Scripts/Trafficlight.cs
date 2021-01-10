using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Trafficlight : MonoBehaviour
{
    public Material Red;
    public Material Yellow;
    public Material Green;
    public Material notRed;
    public Material notYellow;
    public Material notGreen;
    public GameObject Light;
    public static int lampu = 2;
    public Text waktu;
    float timer = 0f;

    void Start()
    {
        ChangeLight();
    }
    
    public void ChangeLight(){
        MeshRenderer changeLight = Light.GetComponent<MeshRenderer>();
        while(true)
        {
            changeLight.materials[1] = Red;
            timer += Time.deltaTime;
            waktu.text = Mathf.Round(timer).ToString();
            
            if (timer == 30 && lampu == 2)
            {
                timer = 0f;
                changeLight.materials[0] = notYellow;
                changeLight.materials[1] = notRed;
                changeLight.materials[2] = Green;
                lampu = 1;
            }

            else if (timer == 30 && lampu == 1)
            {
                timer = 0f;
                changeLight.materials[0] = Yellow;
                changeLight.materials[1] = notRed;
                changeLight.materials[2] = notGreen;
                lampu = 0;
            }

            else if (timer == 3 && lampu == 0)
            {
                timer = 0f;
                changeLight.materials[0] = notYellow;
                changeLight.materials[1] = Red;
                changeLight.materials[2] = notGreen;
                lampu = 2;
            }
        }
    }
}