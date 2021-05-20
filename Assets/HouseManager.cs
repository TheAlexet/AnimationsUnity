using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseManager : MonoBehaviour
{

    [SerializeField]
    private GameObject doorMessage;

    [SerializeField]
    private GameObject enterMessage;

    [SerializeField]
    private GameObject finalPanel;

    [SerializeField]
    private GameObject timeline;

    [SerializeField]
    private GameObject victorySound;

    private bool houseCollided;

    void Update()
    {
        if (houseCollided)
        {
            if (Input.GetKeyDown("f"))
            {
                if (PlayerPrefs.GetInt("keysObtained") == 3)
                {
                    Time.timeScale = 0;
                    finalPanel.SetActive(true);
                    timeline.SetActive(false);
                    victorySound.GetComponent<AudioSource>().Play(0);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            houseCollided = true;
            if (PlayerPrefs.GetInt("keysObtained") == 3)
            {
                enterMessage.SetActive(true);
            }
            else
            {
                doorMessage.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            houseCollided = false;
            doorMessage.SetActive(false);
            enterMessage.SetActive(false);
        }
    }

    public void finalPanelHandler()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Final Deliverable");
    }
}
