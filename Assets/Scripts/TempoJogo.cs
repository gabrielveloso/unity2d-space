using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoJogo : MonoBehaviour
{

    public float tempo;
    public Text tempoText;

    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        tempoText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        tempoText.text = "Time: "+ tempo.ToString("0");

        if(tempo < 0){
            SceneManager.LoadScene(nextScene);
        }
    }

    public void zerar(){
        transform.parent.gameObject.SetActive(false);        
    }
}
