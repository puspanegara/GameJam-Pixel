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
    public HouseCek houseCek;
    public Sprite CheckImage;
    public bool diKunjungi;
    public Text textMenang;
    

    
    // Start is called before the first frame update
    void Start()
    {
        //houseCek = GameObject.FindGameObjectWithTag("Player","Player2").GetComponent<HouseCek>();
        houseCek =GameObject.FindGameObjectWithTag("Pengecekan").GetComponent<HouseCek>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreP1 > scoreP2)
        {
            textMenang.text = "Kamu Menang P1 dengan score" +scoreP1;
        }
        else if ( scoreP1 == scoreP2)
        {
            textMenang.text = "Kalian mendapatkan hasil yang sama P1 "+scoreP1+" || " +"P2 "+ scoreP2 ;
        }
        else
        {
            textMenang.text= "Kamu Menang P2 dengan score"+ scoreP2;
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        for(int i=0; i < houseCek.houses.Length; i++)
        {
            if(diKunjungi == false)
            {
                if(houseCek.isDone[i] == false)
                {
                    if(other.CompareTag("Player"))
                    {
                        scoreP1 ++;
                        houseCek.isDone[i] = true; 
                        diKunjungi= true;
                        Debug.Log(scoreP1);
                        textScorePemain1.text= scoreP1 + "";
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
                        break;       
                    }
                    if(other.CompareTag("Player2"))
                    {
                            scoreP2 ++;
                            houseCek.isDone[i]= true;
                            diKunjungi=true;
                            Debug.Log(scoreP2);
                            textScorePemain2.text= scoreP2 + "";
                            this.gameObject.GetComponent<SpriteRenderer>().sprite = CheckImage;
                            break;
                    }
                } 
            }
             
        }
        
    }
}
