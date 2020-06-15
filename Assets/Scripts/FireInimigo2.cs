using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInimigo2 : MonoBehaviour
{
    
    public float intervalo;
    public GameObject balaPrefab;
    public GameObject balaPosition;
    public GameObject balaPosition2;
    public GameObject balaPosition3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", intervalo, intervalo);
    }

    void Fire(){
        Instantiate(balaPrefab, balaPosition.transform.position, Quaternion.identity);
        Instantiate(balaPrefab, balaPosition2.transform.position, Quaternion.identity);
        Instantiate(balaPrefab, balaPosition3.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
