using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPosition : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [Header("Posicion inical")]
    public Vector3 posicionInicial;

    [Header("Posiciones")]
    [SerializeField] private float movimientoX = 0f;  
    [SerializeField] private float movimientoZ = 0f;  

    [Header("Velocidades2")]
    public float velocidadMovimiento = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Puedes inicializar la posición aquí si lo deseas
        meshRenderer = GetComponent<MeshRenderer>();
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        // Movimiento en el eje X
        if (Input.GetKey(KeyCode.A)) movimientoX -= velocidadMovimiento * Time.deltaTime;  // Mover a la izquierda
        if (Input.GetKey(KeyCode.D)) movimientoX += velocidadMovimiento * Time.deltaTime;  // Mover a la derecha

        // Movimiento en el eje Z
        if (Input.GetKey(KeyCode.S)) movimientoZ -= velocidadMovimiento * Time.deltaTime;  // Mover hacia atrás
        if (Input.GetKey(KeyCode.W)) movimientoZ += velocidadMovimiento * Time.deltaTime;  // Mover hacia adelante

        // Actualizar la posición del objeto sumando el movimiento relativo a la posición inicial
        transform.position = new Vector3(posicionInicial.x + movimientoX, 0.5f, posicionInicial.z + movimientoZ);
    }
}
