using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonmanager : MonoBehaviour
{
    public void startgame()
    {
        PlayerPrefs.SetFloat("mula", 0);
        SceneManager.LoadScene("game");
    }

    public void continuegame()
    {
        SceneManager.LoadScene("game");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
