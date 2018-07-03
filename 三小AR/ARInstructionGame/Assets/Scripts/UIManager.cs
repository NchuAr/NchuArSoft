using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class UIManager : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject readPanel;


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
}
