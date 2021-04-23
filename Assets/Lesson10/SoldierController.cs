using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{

    public float acceleration = 1f;

    private Animator animator;

    private CharacterController charController;

    private float animationValue = 0.02f;

    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    void Update()
    {

        charController.Move(Vector3.down*acceleration*Time.deltaTime);

        //animator.SetFloat("vertical", 0);
        //animator.SetFloat("horizontal", 0);

        if (Input.GetKey(KeyCode.I))
        {
            if (animator.GetFloat("vertical") < 1.0f) animator.SetFloat("vertical", animator.GetFloat("vertical") + animationValue);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            if (animator.GetFloat("vertical") > -1.0f) animator.SetFloat("vertical", animator.GetFloat("vertical") - animationValue);
        }
        else 
        {
            if (animator.GetFloat("vertical") > 0) animator.SetFloat("vertical", animator.GetFloat("vertical") - animationValue);
            else if (animator.GetFloat("vertical") < 0) animator.SetFloat("vertical", animator.GetFloat("vertical") + animationValue);
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (animator.GetFloat("horizontal") > -1.0f) animator.SetFloat("horizontal", animator.GetFloat("horizontal") - animationValue);            
        }
        else if (Input.GetKey(KeyCode.L))
        {
            if (animator.GetFloat("horizontal") < 1.0f) animator.SetFloat("horizontal", animator.GetFloat("horizontal") + animationValue);
        }
        else
        {
            if (animator.GetFloat("horizontal") < 0) animator.SetFloat("horizontal", animator.GetFloat("horizontal") + animationValue);
            else if (animator.GetFloat("horizontal") > 0) animator.SetFloat("horizontal", animator.GetFloat("horizontal") - animationValue);
        }
    }
}
