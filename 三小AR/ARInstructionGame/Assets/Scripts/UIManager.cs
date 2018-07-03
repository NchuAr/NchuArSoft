using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject readPanel;

    void Awake()
    {
        if (PlayerPrefs.GetInt("scene") == 1)
        {
            mainPanel.SetActive(false);
            readPanel.SetActive(true);
            PlayerPrefs.SetInt("scene", 0);
        }
        else
        {
            mainPanel.SetActive(true);
            readPanel.SetActive(false);
        }
    }

    public void ButtonRead()
    {
        mainPanel.SetActive(false);
        readPanel.SetActive(true);
    }

    public void ButtonGame()
    {

    }

    public void ButtonPaint()
    {

    }

    public void Setting()
    {
       
    }


    public void ReadReturn()
    {
        mainPanel.SetActive(true);
        readPanel.SetActive(false);
    }

    public void ReadAnimal()
    {
        PlayerPrefs.SetInt("scene", 1);
        SceneManager.LoadScene(1);
    }
}
