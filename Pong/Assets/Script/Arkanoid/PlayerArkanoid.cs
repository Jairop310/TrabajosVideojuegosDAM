using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArkanoid : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5;
    private float bound = 4.5f;
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x+moveInput*moveSpeed*Time.deltaTime,-bound,bound);
        transform.position = playerPosition;

    }
}
