using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseCek : MonoBehaviour
{
    public bool[] isDone;
    public GameObject[] houses;
   public GameObject donePanel;

   void Update() 
   {
    for(int i=0; i <isDone.Length; i++)
    {
        if(isDone[i] == true)
        {
            donePanel.SetActive(true);
        }
    }
   }
}
