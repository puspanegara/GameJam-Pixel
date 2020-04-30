using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    float t;
    public float startTime;   
    public GameObject donePanel;
    void Start() 
    {
        t = startTime;    
    }
    // Update is called once per frame
    void Update()
    {
        t -= 1  *Time.deltaTime;
        string minute= ((int) t/60).ToString();
        string second= ((int) t%60).ToString("f0");

        timerText.text = minute + " : " + second; 

        if(t <= 0)
        {
            t=0;
            OpenDonePanel();
        }
    }

    public void OpenDonePanel()
    {
        donePanel.SetActive(true);
    }
}
