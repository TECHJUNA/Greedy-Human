using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncash : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float MinX,MaxX;
    public GameObject[] Cash;
    [SerializeField]
    float Spawninterval;
    public static Spawncash instance;
    private void Awake(){
        if(instance==null){
            instance=this;
        }
    }
    void Start()
    {
      StartSpwcash();
    }
    void Scash(){
        int random = Random.Range(0,Cash.Length);
        float ranX = Random.Range(MinX,MaxX);
        Vector3 randompos = new Vector3(ranX,transform.position.y,transform.position.z);

        Instantiate(Cash[random],randompos,transform.rotation);
    }
    
    IEnumerator Spwcash(){
        yield return new WaitForSeconds(2f);

        while(true){
            Scash();
            yield return new WaitForSeconds(Spawninterval);
        }
    }
   public void StartSpwcash(){
      StartCoroutine("Spwcash");
   }
   public void stopSpwcash(){
      StopCoroutine("Spwcash");
   }


}
