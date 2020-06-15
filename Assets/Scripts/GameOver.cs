using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

 
    public GameObject container;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void gameOver(){
        print("fim");
        FindObjectOfType<TempoJogo>().zerar();
        FindObjectOfType<ScoreScript>().zerar();
        container.SetActive(true);
    }

    public void restart(){      
        SceneManager.LoadScene("Level1");
    }
    
}
