using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ShouldDie(collision))
        {
            Destroy(gameObject);
        }
    }

    private bool ShouldDie(Collision2D collision)
    {
        bool isBird = collision.gameObject.GetComponent<Bird>();
        if (isBird)
        {
            return true;
        }
        bool isCrished = collision.contacts[0].normal.y < -0.5f;

        if (isCrished)
        {
            return true;
        }

        return false;
    }

}