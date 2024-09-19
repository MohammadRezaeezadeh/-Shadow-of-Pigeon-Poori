using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class donbal : MonoBehaviour
{






    public Animator animator;
    private float originalPosition;
    private bool hasMoved = false;
    public int x;

    void Start()
    {
        originalPosition = transform.position.x;
    }

    void Update()
    {
        float horizontal = animator.GetFloat("MoveX");

        if (horizontal < 0 && !hasMoved)
        {
            transform.position = new Vector3(transform.position.x - x, transform.position.y, transform.position.z);
            hasMoved = true;
        }
        // شرط جدید برای بازگشت به موقعیت اولیه
        else if (horizontal >= 0 && hasMoved)
        {
            transform.position = new Vector3(originalPosition, transform.position.y, transform.position.z);
            hasMoved = false;
        }
    }
}



    

    

