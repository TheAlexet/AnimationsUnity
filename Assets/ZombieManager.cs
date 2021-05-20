using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieManager : MonoBehaviour
{

    [SerializeField]
    private GameObject finalPanel;

    [SerializeField]
    private GameObject timeline;

    [SerializeField]
    private GameObject defeatSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            finalPanel.SetActive(true);
            timeline.SetActive(false);
            defeatSound.GetComponent<AudioSource>().Play(0);
        }
    }

    public void finalPanelHandler()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Final Deliverable");
    }
}
