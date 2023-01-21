using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    private bool isMovingLeft = false, isMovingRight = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || isMovingLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || isMovingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void OnLeftButtonDown()
    {
        isMovingLeft = true;
    }

    public void OnLeftButtonUp()
    {
        isMovingLeft = false;
    }

    public void OnRightButtonDown()
    {
        isMovingRight = true;
    }

    public void OnRightButtonUp()
    {
        isMovingRight = false;
    }
}
