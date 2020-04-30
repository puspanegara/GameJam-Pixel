using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    static int scoreP1;
    static int scoreP2;
    public Text textScorePemain1;
    public Text textScorePemain2; 
    private HouseCek houseCek;
    public Sprite CheckImage;
    public GameObject image;
    
    //public bool diKunjungi;
    // Start is called before the first frame update
    void Start()
    {
        //houseCek = GameObject.FindGameObjectWithTag("Player","Player2").GetComponent<HouseCek>();
        houseCek =GameObject.FindGameObjectWithTag("Pengecekan").GetComponent<HouseCek>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            /*for (int i=0; i< houseCek.houses.Length; i++)
            {
                if(houseCek.isDone[i] == false)
                {
                    houseCek.isDone[i] = true;
                    //Instantiate(imageCek, houseCek.houses[i].transform, false); 
                    this.gameObject.GetComponent<SpriteRenderer>().sprite= CheckImage;
                    break;
                }
            }
            if(diKunjungi == false)
            {
               scoreP1 ++;
               diKunjungi = true;
               Debug.Log(scoreP1);
               textScorePemain1.text= scoreP1 + "";
               this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
            }
        }  
        if (other.CompareTag("Player2"))
        {
            if(diKunjungi == false)
            {
                scoreP2 ++;
                //diKunjungi = true;
                Debug.Log(scoreP2);
                textScorePemain2.text= scoreP2 + "";
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
            }
        }
    }*/
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        for(int i=0; i < houseCek.isDone.Length; i++)
        {
            if(houseCek.isDone[i]== false)
            {
                if(other.CompareTag("Player"))
                {
                    scoreP1 ++;
                    houseCek.isDone[i] = true; 
                    Debug.Log(scoreP1);
                    textScorePemain1.text= scoreP1 + "";
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
                    break;
                }
                if(other.CompareTag("Player2"))
                {
                        scoreP2 ++;
                        houseCek.isDone[i]= true;
                        Debug.Log(scoreP2);
                        textScorePemain2.text= scoreP2 + "";
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
                        break;
                }
            } 
        }
        
    }
}
