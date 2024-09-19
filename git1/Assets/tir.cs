using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tir : MonoBehaviour
{
    public Animator animator;
    private float originalPosition;
    private bool hasMoved = false;
    public GameObject poori;

    void Start()
    {
        originalPosition =poori.transform.position.x;
    }

    void Update()
    {
        float horizontal = animator.GetFloat("MoveX");

        if (horizontal < 0 && !hasMoved)
        {
            transform.position = new Vector3(originalPosition * -1, transform.position.y, transform.position.z);
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
