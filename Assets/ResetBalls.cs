using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBalls : MonoBehaviour
{

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public Text scoreLabel;

    public void resetButtonHandler() 
    {

        ball1.SetActive(false);
        ball1.transform.position = new Vector3(-4.985f, 4.32f, 0f);
        ball1.SetActive(true);

        ball2.SetActive(false);
        ball2.transform.position = new Vector3(-4.985f, 4.4f, 0.9f);
        ball2.SetActive(true);

        ball3.SetActive(false);
        ball3.transform.position = new Vector3(-4.985f, 4.6f, 1.7f);
        ball3.SetActive(true);

        ball4.SetActive(false);
        ball4.transform.position = new Vector3(-4.985f, 4.65f, 2.4f);
        ball4.SetActive(true);

        ball5.SetActive(false);
        ball5.transform.position = new Vector3(-4.985f, 4.7f, 3f);
        ball5.SetActive(true);

        scoreLabel.GetComponent<Text>().text = "Score: 0";

    }

}
