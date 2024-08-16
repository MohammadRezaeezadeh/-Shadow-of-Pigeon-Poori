using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
{
    [SerializeField] private InputActionReference actionReference;
    public float speed;
     private  Rigidbody2D godpoori;
    private Vector2 change;
    private Vector2 delta;
    private Animator animator;
  
    void Start()
    {
        animator = GetComponent<Animator>();
        godpoori = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        delta = actionReference.action.ReadValue<Vector2>();
        UpdateAnimationMobile();
       

    }
    void UpdateAnimation()
    {
        if (change != Vector2.zero)
        {
            MoveCharacter();
            animator.SetFloat("MoveX", change.x);
            animator.SetFloat("MoveY", change.y);
            animator.SetBool("moving", true);

        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void UpdateAnimationMobile()
    {
        if (delta != Vector2.zero)
        {
            MoveCharacterMobile();
            animator.SetFloat("MoveX", delta.x);
            animator.SetFloat("MoveY", delta.y);
            animator.SetBool("moving", true);

        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
    void MoveCharacterMobile()
    {
        transform.Translate(delta * speed * Time.deltaTime);

    }
    void MoveCharacter()
    {
        transform.Translate(change * speed * Time.deltaTime);
    }
}
