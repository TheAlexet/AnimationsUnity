using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ControlAnimaciones : MonoBehaviour
{

    public Animator animator;
    public string parametroBoolean;
    bool b = false;
    int i;
    int pos = 0;
    int[] array = new int[10];

    void Start() {
        i = 0;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            if (i == 0) 
            {
                b = !b;
                animator.SetBool(parametroBoolean, b);
                i = i + 1;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            i = 0;
        }
    }
}
