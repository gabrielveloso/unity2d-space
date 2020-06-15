using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D outro) {
      if(outro.gameObject.name != "Nave"){
          Destroy(outro.gameObject);
      }

  }
}
