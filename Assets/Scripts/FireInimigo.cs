using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInimigo : MonoBehaviour
{

    public float intervalo;
    public GameObject balaPrefab;
    public GameObject balaPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", intervalo, intervalo);
    }

    void Fire(){
        Instantiate(balaPrefab, balaPosition.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
