using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{   
    /* não está sendo mais utilizado, pois trocou-se para o script controller*/

    public float speed = 5;

    void FixedUpdate(){
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("idle", (v == 0));
    }
  
}
