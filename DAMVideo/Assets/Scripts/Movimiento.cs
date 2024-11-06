using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadMovimiento = 5f;       // Velocidad de movimiento hacia adelante/atrás
    public float velocidadRotacion = 100f;       // Velocidad de rotación
    public float fuerzaSalto = 7f;               // Fuerza del salto

    private Animator animator;                   // Referencia al Animator
    private Rigidbody rb;                        // Referencia al Rigidbody
    private bool enSuelo = true;                        // Booleano para verificar si está en el suelo

    private void Start()
    {
        // Obtener el componente Animator y Rigidbody del personaje
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Capturar la entrada de rotación (A y D) y de movimiento hacia adelante/atrás (W y S)
        float rotacion = Input.GetAxis("Horizontal"); // A y D para rotar
        float movimiento = Input.GetAxis("Vertical"); // W y S para moverse hacia adelante o atrás

        // Rotar el personaje en el eje Y según la velocidad de rotación
        transform.Rotate(0f, rotacion * velocidadRotacion * Time.deltaTime, 0f);

        // Mover al personaje hacia adelante o atrás en el eje Z (dirección forward)
        Vector3 direccionMovimiento = -1*transform.forward * movimiento * velocidadMovimiento * Time.deltaTime;
        transform.position += direccionMovimiento;

        // Cambiar la velocidad del Animator basada en la magnitud del movimiento
        animator.SetFloat("velocidad", Mathf.Abs(movimiento));

        // Saltar si está en el suelo y se presiona la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }


}
