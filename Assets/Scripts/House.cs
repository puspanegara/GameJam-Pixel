using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    public string buttonUse;
    public int countHouseGet;
    public Text countHouseText; 
    private HouseCek houseCek;
    public GameObject imageCek;
    // Start is called before the first frame update
    void Start()
    {
        houseCek = GameObject.FindGameObjectWithTag("Player").GetComponent<HouseCek>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
          if(other.CompareTag("Player"))
          {
            for (int i=0; i< houseCek.houses.Length; i++)
            {
                if(houseCek.isDone[i] == false)
                {
                    houseCek.isDone[i] = true;
                    Instantiate(imageCek, houseCek.houses[i].transform, false); 
                    break;
                }
            }
          }  
    }
}
