using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludos : MonoBehaviour
{
    public string presentacion = "Hello World";
    private int ContadorFrame = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(presentacion);
        print(transform.position);
        print(transform.rotation);
        print(transform.localScale);
        print(transform.eulerAngles);

    }

    // Update is called once per frame
    void Update()
    {
        // ContadorFrame++;
        // Debug.Log(ContadorFrame);
        /*print(transform.position);
        print(transform.rotation);
        print(transform.localScale);
        print(transform.eulerAngles);*/
    }
}
