using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScripPingPongCubos : MonoBehaviour
{
    public GameObject[] cajas;

    public Color[] color;
    public Vector3[] direcciones;

    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cajas.Length; i++)
        {
            cajas[i].GetComponent<MeshRenderer>().material.color = color[i];
        }
        direcciones = new Vector3[] {Vector3.right,Vector3.left,Vector3.right,Vector3.left};
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cajas.Length; i++)
        {
            cajas[i].transform.position += (i + 1) * direcciones[i] * Time.deltaTime;
            if (cajas[i].transform.position.x < -4) { 

                direcciones[i] = Vector3.right;
            }
            else if (cajas[i].transform.position.x > 4)
            {
                direcciones[i] = Vector3.left;
            }
        }

    }
}
