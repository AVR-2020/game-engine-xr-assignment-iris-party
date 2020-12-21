using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputKey))]
public class Kontrol : MonoBehaviour
{
    public InputKey masukkan;
    public List<WheelCollider> rodaPenggerak;
    public List<GameObject> rodaStir;
    public List<GameObject> rodaPutar;
    public List<GameObject> stir;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        masukkan = GetComponent<InputKey>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(WheelCollider roda in rodaPenggerak)
        {
            roda.motorTorque = (200f * Time.deltaTime * masukkan.penggerak) * 10; 
        }

        foreach(GameObject roda in rodaStir)
        {
            roda.GetComponent<WheelCollider>().steerAngle = 45f * masukkan.stir;
            roda.transform.localEulerAngles = new Vector3(0f, masukkan.stir * 45f, 0f);
        }

        foreach(GameObject stirMobil in stir)
        {
            stirMobil.transform.localEulerAngles = new Vector3(masukkan.stir * -5f, 180f + (masukkan.stir * 5f), masukkan.stir * 45f);
        }

        foreach (GameObject putar in rodaPutar)
        {
            putar.transform.Rotate(0f, 0f, rb.velocity.magnitude * (transform.InverseTransformDirection(rb.velocity).z >= 0 ? 1 : -1) / (0.5f * Mathf.PI * 0.33f));
        }
    }
}
