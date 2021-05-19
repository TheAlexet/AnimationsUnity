using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{

    [SerializeField]
    private GameObject playerCam;

    private Animator animator;
    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    public float gravity = 10.0f;

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

        //moveDirection.y -= gravity * Time.deltaTime;
        //characterController.Move(moveDirection * Time.deltaTime);

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
