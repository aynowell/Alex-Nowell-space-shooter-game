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
        PlayerPrefs.SetBool("metior",true);
    }
    public void buyforcefield(){
        PlayerPrefs.SetBool("force field",true);
    }
    public void buyminion(){
        PlayerPrefs.SetBool("monion",true);
    }
    public void buybomb(){
        PlayerPrefs.SetBool("bomb",true);
    }
       public void buygun(){
        PlayerPrefs.SetBool("gun",true);
    }
    public void buysonicboom(){
        PlayerPrefs.SetBool("sonic boom",true);
    }
     
}
