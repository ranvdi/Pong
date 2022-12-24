using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public bool isPlayer1Goal;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored... GOOOOAAAAAAALLLLLL!");
                GameObject.FindObjectOfType<AudioManager>().playsong("Point2");
                GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
                GameObject.Find("GameManager").GetComponent<GameManager>().resetPosition();
            }
            else
            {
                Debug.Log("Player 2 Scored... GOOOOAAAAAAALLLLLL!");
                GameObject.FindObjectOfType<AudioManager>().playsong("Point2");
                GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
                GameObject.Find("GameManager").GetComponent<GameManager>().resetPosition();
            }
        }
    }
}
