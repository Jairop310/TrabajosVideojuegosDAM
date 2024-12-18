using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 initialVelocity;
    [SerializeField] private float velocityMultipler;

    private Rigidbody2D body;
    private bool isBallMoving;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Launch();
    }

    private void Launch()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            transform.parent = null;
            body.velocity = initialVelocity;
            isBallMoving = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            body.velocity *= velocityMultipler;
            GameManager.Instance.BlockDestroyed();
        }
        VelocityFix();
    }
    private void VelocityFix()
    {
        float velocityDe1ta = 0.5f;
        float minVelocity = 0.2f;
        
        if(Mathf.Abs(body.velocity.x)< minVelocity)
        {
            velocityDe1ta *= Random.value<0.5f ? velocityDe1ta :-velocityDe1ta;
            body.velocity *= new Vector2(velocityDe1ta,0f); 
        }
        if (Mathf.Abs(body.velocity.y) < minVelocity)
        {
            velocityDe1ta *= Random.value < 0.5f ? velocityDe1ta : -velocityDe1ta;
            body.velocity *= new Vector2(0f, velocityDe1ta);
        }
    }

}
