using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{

    private Animator animator;
    private CharacterController characterController;

    public float gravity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //characterController.Move(Vector3.down * gravity * Time.deltaTime);

        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", 0);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("vertical", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("vertical", -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("horizontal", -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("horizontal", 1);
        }
    }
}
