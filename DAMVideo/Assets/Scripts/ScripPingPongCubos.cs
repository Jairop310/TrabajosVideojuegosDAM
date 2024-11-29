using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripPingPongCubos : MonoBehaviour
{
    public MeshRenderer[] meshRenderer;
    public Color[] color;

    public Vector3[] direcciones;
    public Transform[] bloques;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < meshRenderer.Length; i++)
        {
            meshRenderer[i].material.color = color[i];
        }
        
        direcciones = new Vector3[] {Vector3.right,Vector3.left,Vector3.right,Vector3.left};
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bloques.Length; i++)
        {
            bloques[i].position += (i + 1) * direcciones[i] * Time.deltaTime;
            if (bloques[i].position.x < -4)
            {
                direcciones[i] = Vector3.right;
            }
            else if (bloques[i].position.x > 4)
            {
                direcciones[i] = Vector3.left;
            }
        }

    }
}
