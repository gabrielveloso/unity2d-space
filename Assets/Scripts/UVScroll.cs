using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour
{
   public Vector2 speed;
   
   void LateUpdate(){       
       this.GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
   }   
    
}
