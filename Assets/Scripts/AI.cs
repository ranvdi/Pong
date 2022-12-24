using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float movementSpeed = 6.0f;
    public float topBound = 3.85f;      //Tavan s?n?r
    public float bottomBound = -3.85f;  //Taban s?n?r
    public float leftBound = -8.77f;    //Sol s?n?r
    public float rightBound = -0.4f;     //Sa? s?n?r
    public Vector2 startingPosition = new Vector2(8.45f, 0.0f);
    void Start()
    {
        transform.localPosition = (Vector3)startingPosition;
    }

    void Update()
    {
        PlayerControlInput();
    }

    void PlayerControlInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.localPosition.y >= topBound)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, topBound, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.up * movementSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.localPosition.y <= bottomBound)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, bottomBound, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.down * movementSpeed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x >= rightBound)
            {
                transform.localPosition = new Vector3(rightBound, transform.localPosition.y, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.right * movementSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localPosition.x <= leftBound)
            {
                transform.localPosition = new Vector3(leftBound, transform.localPosition.y, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.left * movementSpeed * Time.deltaTime;
            }
        }
    }
}