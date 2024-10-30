using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float Giro;
    public GameObject Bola;
    Vector3 PosicionOriginal;
    void Start()
    {
        PosicionOriginal = Bola.transform.position;
        print("El codigo esta encendido");
    }

    // Update se llama una vez por cuadro
    void Update()
    {

        float rotacionHorizontal = Input.GetAxis("Horizontal") * Giro * Time.deltaTime;
        float rotacionVertical = Input.GetAxis("Vertical") * Giro * Time.deltaTime;


        transform.Rotate(rotacionVertical, rotacionHorizontal, 0);

        if (Bola.transform.position.y <= -100)
        {
            Bola.transform.position = PosicionOriginal; 
        }
    }
}

