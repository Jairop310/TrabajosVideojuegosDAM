using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float force;
    [SerializeField] private float maxDistance = 2;
    private Rigidbody2D rb;
    public Camera camera;
    private Vector2 startPosition, clampedPositoin;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        setPosition();
    }

    private void setPosition()
    {
        Vector2 dragPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        clampedPositoin = dragPosition;

        float dragDistance = Vector2.Distance(startPosition, dragPosition);

        if (dragDistance > maxDistance)
        {
            clampedPositoin = startPosition + (dragPosition - startPosition).normalized * maxDistance;
        }

        if (dragPosition.x > startPosition.x)
        {
            clampedPositoin.x = startPosition.x;
        }
        transform.position = clampedPositoin;
    }

    private void OnMouseUp()
    {
        Throw();
    }

    private void Throw()
    {
        rb.isKinematic = false;
        Vector2 throwVector = startPosition - clampedPositoin;
        rb.AddForce(throwVector * force);
        float resetTime = 5f;
        Invoke("Reset", resetTime);
    }

    private void Reset()
    {
        transform.position = startPosition;
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
        camera.GetComponent<CameraMovement>().ResetPosition();
    }
}