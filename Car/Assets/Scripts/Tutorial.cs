using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text text;
    public GameObject tutorial;

    void Update()
    {
        Time.timeScale = 0f;
    }
    public void Awal()
    {
        text.text = "Usahakan tidak menabrak apapun yang membatasi tempat parkir";
    }

    public void Rambu()
    {
        text.text = "Marka adalah garis putih yang membagi jalan \nJangan melewati garis putih yang membagi jalan jika itu bersambung \nGaris yang tidak bersambung dapat dilewati";
    }

    public void Lampu()
    {
        text.text = "Berjalan ketika warna lampu tidak berwarna merah \n Jika lampu merah, diharap untuk berhenti dibelakang garis";
    }

    public void mulai()
    {
        tutorial.SetActive(false);
        Time.timeScale = 1f;
    }
}
