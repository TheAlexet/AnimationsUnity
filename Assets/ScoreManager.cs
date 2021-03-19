using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

	public Text scoreLabel;

	private int scoreCount;

    void Start()
    {
        scoreCount = 0;
        scoreLabel.GetComponent<Text>().text = "Score: " + scoreCount.ToString();
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            scoreCount = int.Parse(scoreLabel.GetComponent<Text>().text.Substring(7));
            scoreCount = scoreCount + 1;
            scoreLabel.GetComponent<Text>().text = "Score: " + scoreCount.ToString();
        }

    }

}
