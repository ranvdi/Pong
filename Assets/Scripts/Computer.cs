using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Computer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private Transform target;
    public float speed;

    void Start()
    {
        startPosition = transform.position;
        target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;         //Sifirlanma sonrasi baslangic konumuna donus
    }
}