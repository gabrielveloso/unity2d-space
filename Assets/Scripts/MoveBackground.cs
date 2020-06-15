using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* não está sendo mais utilizado*/
public class MoveBackground : MonoBehaviour
{

    public float limite = -15f;
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.localPosition.y < limite)
        {
            
            Instantiate(back,  new Vector3(transform.localPosition.x, limite*(-2), transform.localPosition.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
        
        transform.Translate(0, -Time.deltaTime, 0);
    }
}
