using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmanucontrol : MonoBehaviour
{
    public void play(){
        SceneManager.LoadScene("GAME");
    }
    public void Quit(){
       Application.Quit();  
    }
}
