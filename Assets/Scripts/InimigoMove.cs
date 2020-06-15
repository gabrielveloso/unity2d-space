using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMove: MonoBehaviour
{
    public Vector2 velocidade;

    // Start is called before the first frame update
    void Start()
    {
        

         if(GetComponent<Rigidbody2D>().tag == "inimigo4"){
            GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-0.5f, 0.5f), velocidade.y);
        }else{
           GetComponent<Rigidbody2D>().velocity = velocidade; 
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
