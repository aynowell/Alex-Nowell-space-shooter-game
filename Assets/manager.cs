using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manager : MonoBehaviour
{
    public void gobacktostartscreen()
    {
        SceneManager.LoadScene("Start Screen");
    }
    public void gotoshop()
    {
        SceneManager.LoadScene("shop scene");
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
