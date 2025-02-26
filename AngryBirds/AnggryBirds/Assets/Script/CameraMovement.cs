using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform birdTransform;
    [SerializeField] private float xStopPosition;

    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    private void LateUpdate()
    {
        if (birdTransform.position.x > transform.position.x && transform.position.x < xStopPosition)
        {
            transform.position = new Vector3(birdTransform.position.x, transform.position.y, transform.position.z);
        }
    }
    public void ResetPosition()
    {
        transform.position = startPosition;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
