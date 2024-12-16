using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.WSA;

public class Contador : MonoBehaviour
{
    [SerializeField] private TMP_Text Player1Score;
    [SerializeField] private TMP_Text Player2Score;

    [SerializeField] private Transform Player1Transform;
    [SerializeField] private Transform Player2Transform;
    [SerializeField] private Transform ballTransform;

    private int player1Score;
    private int player2Score;
    
    private static Contador instance;
    public static Contador Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Contador>();
            }
            return instance;
        }
    }
    public void PuntuacionPlayer1()
    {
        player1Score++;
        Player1Score.text = player1Score.ToString();
    }
    public void PuntuacionPlayer2()
    {
        player2Score++;
        Player2Score.text = player2Score.ToString();
    }
    public void Restart()
    {
        Player1Transform.position = new Vector2(Player1Transform.position.x, 0);
        Player2Transform.position = new Vector2(Player2Transform.position.x, 0);
        ballTransform.position = Vector2.zero;
    }

}
