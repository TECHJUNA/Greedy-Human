using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   
     void OnTriggerEnter2D(Collider2D other) {
            
          if(other.gameObject.tag =="Player"){
         
          GameManager.instance.IncrementScore();

         Destroy(gameObject);
        }
         else if(other.gameObject.tag =="Bottom"){
            GameManager.instance.Decrementlives();
            Destroy(gameObject);
     }
    }
}

           

        


