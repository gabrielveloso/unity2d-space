using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigos : MonoBehaviour
{
    public GameObject[] inimigos;
    public float timeMax = 2f;
    public GameObject inimigo;

     private float posY = 4;

    private float timer;

    // Start is called before the first frame update
    void Start(){
    }

     private void Update() {
        if (timer > timeMax){
            GameObject ini = Instantiate(inimigo);
            ini.transform.position = this.transform.position +  new Vector3(Random.Range(-3, 3), posY, 0);
            timer = 0;
            Destroy(ini, 15);
        }
        timer += Time.deltaTime;
    }
}
