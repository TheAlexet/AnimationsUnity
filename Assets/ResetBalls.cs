using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBalls : MonoBehaviour
{

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;

    public void resetButtonHandler() {

        ball1.SetActive(false);
        ball1.transform.position = new Vector3(-4.985f, 4.32f, 0f);
        ball1.SetActive(true);

        ball2.SetActive(false);
        ball2.transform.position = new Vector3(-0.281f, 0.661f, 4.713f);
        ball2.SetActive(true);

        ball3.SetActive(false);
        ball3.transform.position = new Vector3(-4.985f, 4.32f, 0f);
        ball3.SetActive(true);

        ball4.SetActive(false);
        ball4.transform.position = new Vector3(-4.985f, 4.32f, 0f);
        ball4.SetActive(true);

        ball5.SetActive(false);
        ball5.transform.position = new Vector3(-4.985f, 4.32f, 0f);
        ball5.SetActive(true);

    }

}
