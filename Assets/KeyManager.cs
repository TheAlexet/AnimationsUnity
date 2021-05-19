using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{

    [SerializeField]
    private GameObject interfaceKey1;

    [SerializeField]
    private GameObject interfaceKey2;

    [SerializeField]
    private GameObject interfaceKey3;

    [SerializeField]
    private GameObject obtainKeyMessage;

    private bool thisKeyCollided;

    void Start()
    {
        thisKeyCollided = false;
        interfaceKey1.GetComponent<Image>().sprite = Resources.Load<Sprite>("KeyMissing");
        interfaceKey2.GetComponent<Image>().sprite = Resources.Load<Sprite>("KeyMissing");
        interfaceKey3.GetComponent<Image>().sprite = Resources.Load<Sprite>("KeyMissing");
        PlayerPrefs.SetInt("keysObtained", 0);
    }

    void Update()
    {
        if (thisKeyCollided)
        {
            if (Input.GetKeyDown("f"))
            {
                string keyObtained = this.name;
                switch(keyObtained)
                {
                    case "Key1":
                        interfaceKey1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Key");
                        break;
                    case "Key2":
                        interfaceKey2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Key");
                        break;
                    case "Key3":
                        interfaceKey3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Key");
                        break;
                }
                PlayerPrefs.SetInt("keysObtained", PlayerPrefs.GetInt("keysObtained", 0) + 1);
                thisKeyCollided = false;
                obtainKeyMessage.SetActive(false);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            thisKeyCollided = true;
            obtainKeyMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            thisKeyCollided = false;
            obtainKeyMessage.SetActive(false);
        }
    }


}
