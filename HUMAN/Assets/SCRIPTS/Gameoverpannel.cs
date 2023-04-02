using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameoverpannel : MonoBehaviour
{
    
    public void FinalScore(){
        GameManager.instance.IncrementScore();
    }
    public void ReStart()
    {
        SceneManager.LoadScene("GAME");
    }
    public void UpdateToMenu()
    {
         SceneManager.LoadScene("Main menu");
    }

}
