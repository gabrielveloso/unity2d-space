using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Fire : MonoBehaviour
{
    public GameObject bala;
    public GameObject balaEsquerda;
    public GameObject balaDireita;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bala, balaEsquerda.transform.position, Quaternion.identity);
            Instantiate(bala, balaDireita.transform.position, Quaternion.identity);
        }

        
        if(CrossPlatformInputManager.GetButtonDown("Fire1")){
            Instantiate(bala, balaEsquerda.transform.position, Quaternion.identity);
            Instantiate(bala, balaDireita.transform.position, Quaternion.identity);
        }
    }
}
