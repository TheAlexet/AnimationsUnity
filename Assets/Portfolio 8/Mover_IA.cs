using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover_IA : MonoBehaviour
{

    public Transform goal;
    NavMeshAgent agent;
    Animator animatorPersonaje;
    public Camera camara;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animatorPersonaje = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = hit.point;
            }
        }

        /*if (agent.isOnOffMeshLink) 
        {
            animatorPersonaje.SetTrigger("Saltar");
        }*/

        animatorPersonaje.SetFloat("horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animatorPersonaje.SetFloat("vertical", transform.InverseTransformDirection(agent.velocity).z);
    }
}
