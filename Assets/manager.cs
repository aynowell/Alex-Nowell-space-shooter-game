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

    public void buymeteor(){
        PlayerPrefs.SetString("meteor","true");
    }
    public void buyforcefield(){
        PlayerPrefs.SetString("force field","true");
    }
    public void buyminion(){
        PlayerPrefs.SetString("minion","true");
    }
    public void buybomb(){
        PlayerPrefs.SetString("bomb","true");
    }
       public void buygun(){
        PlayerPrefs.SetString("gun","true");
    }
    public void buysonicboom(){
        PlayerPrefs.SetString("sonic boom","true");
    }
}
