using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int Score =0;
    public int value;
    int Live=3;
    public GameObject LivePanal;
    public GameObject GameOverPanel;
    [SerializeField]
    private Text ScoreText;
    public Text FinalScore;
    public bool GameOver=false;
   
    public void Awake(){
        instance=this;
    }
    public void IncrementScore(){
       if(!GameOver){
        checktags();
        Score++;
        ScoreText.text=Score.ToString();
       }  
       FinalScore.text=Score.ToString(); 
    }
   public void Decrementlives(){
    if(Live>0){
        Live--;
        LivePanal.transform.GetChild(Live).gameObject.SetActive(false);
    }
    if(Live<=0){
        GameOver=true;
        Gameover();
    }
   } 
   public void Gameover(){
    Spawncash.instance.stopSpwcash();
    GameObject.Find("Player").GetComponent<Playercontrol>().CanMove=false;
    GameOverPanel.SetActive(true);
   } 

     void checktags()
    {
        void OnTriggerEnter2D(Collider2D Money)
        {
            if (Money.CompareTag("point10"))
            {
                Score += 10;
            }
            else if (Money.CompareTag("point20"))
            {
                Score += 20;
            }
            else if (Money.CompareTag("point25"))
            {
                Score += 25;
            }
            else if (Money.CompareTag("point50"))
            {
                Score += 50;
            }
        }
    }
   
}

