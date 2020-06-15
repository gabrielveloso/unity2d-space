using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextoStage : MonoBehaviour
{
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = SceneManager.GetActiveScene().name;
        Destroy(texto, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
