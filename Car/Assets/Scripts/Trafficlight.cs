using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Trafficlight : MonoBehaviour
{
    public Color Red;
    public Color Yellow;
    public Color Green;
    public Color notRed;
    public Color notYellow;
    public Color notGreen;
    public GameObject Light;
    public static int lampu = 2;

    void Start()
    {
        StartCoroutine(ChangeLight());
        
    }

    public IEnumerator ChangeLight()
    {
        MeshRenderer changeLight = Light.GetComponent<MeshRenderer>();
        changeLight.materials[1].SetColor("_Color", Red);
        while(true)
        {
            yield return new WaitForSeconds(10f);

            changeLight.materials[0].SetColor("_Color", notYellow);
            changeLight.materials[1].SetColor("_Color", notRed);
            changeLight.materials[2].SetColor("_Color", Green);
            lampu = 1;
            yield return new WaitForSeconds(10f);

            changeLight.materials[0].SetColor("_Color", Yellow);
            changeLight.materials[1].SetColor("_Color", notRed);
            changeLight.materials[2].SetColor("_Color", notGreen);
            lampu = 0;
            yield return new WaitForSeconds(2f);

            changeLight.materials[0].SetColor("_Color", notYellow);
            changeLight.materials[1].SetColor("_Color", Red);
            changeLight.materials[2].SetColor("_Color", notGreen);
            lampu = 2;
            
        }
    }
}