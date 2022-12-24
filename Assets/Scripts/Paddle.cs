using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public GameManager Gm;

    private float movement;
    void Start()
    {
        startPosition = transform.position;         //Baslangic Konumu
    }

    void Update()
    {
            if (isPlayer1)          //Dikey Hareket
            {
                movement = Input.GetAxisRaw("Vertical");
            }
            else
            {
                movement = Input.GetAxisRaw("Vertical2");
            }
            rb.velocity = new Vector2(rb.velocity.x, movement * speed);

            if (isPlayer1)          //Yatay Hareket
            {
                movement = Input.GetAxisRaw("Horizontal");
            }
            else 
            {
                movement = Input.GetAxisRaw("Horizontal2");
            }
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);
            if (Input.GetKey(KeyCode.P))
            {
                Gm.PauseGame();
            }
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;         //Sifirlanma sonrasi baslangic konumuna donus
    }
}
