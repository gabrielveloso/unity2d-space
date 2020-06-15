using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dano : MonoBehaviour
{   


     void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name != "Background" ){
          print(other.gameObject.tag);
            print(this.gameObject.tag);
          if(!(other.gameObject.tag == "ship" && this.gameObject.tag == "BalaVermelha")){
            if(other.gameObject.tag == "ship"){            
                other.gameObject.SetActive(false);
                Destroy(this.gameObject);
                FindObjectOfType<GameOver>().gameOver();  
                         
            }else{
              ScoreScript.scoreValue += 10;
                Destroy(other.gameObject);
                Destroy(this.gameObject); 
            }
          }else{
            //fazer nada
          }
          
        }       
        
    }
}
