using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcefield : MonoBehaviour
{
    public float forcefieldtime;
 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,forcefieldtime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
