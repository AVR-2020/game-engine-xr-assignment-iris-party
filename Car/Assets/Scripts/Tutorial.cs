using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text text;
    public GameObject tutorial;

    public void Awal()
    {
        text.text = "W A S D untuk menjalankan mobil \n";
    }

    public void Rambu()
    {
        text.text = "Jangan melewati garis putih yang membagi jalan jika itu bersambung \n Garis yang tidak bersambung dapat dilewati";
    }

    public void Lampu()
    {
        text.text = "Berjalan ketika warna lampu tidak berwarna merah \n Jika lampu merah, diharap untuk berhenti dibelakang garis";
    }

    public void mulai()
    {
        tutorial.SetActive(false);
    }
}
