using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
   public bool CanMove = true;
     
    [SerializeField]
    float speedplayer;
    [SerializeField]
    float Maxpos;
   
    void Update()
    {
        if(CanMove){
            Move();
        }
        
        void Move(){
            float InputX=(Input.GetAxis("Horizontal"));
            transform.position = transform.position + Vector3.right*InputX*speedplayer*Time.deltaTime;

            float Xpos = Mathf.Clamp(transform.position.x, -Maxpos,Maxpos);

            transform.position=new Vector3(Xpos,transform.position.y,transform.position.z);
        }

    }
}
