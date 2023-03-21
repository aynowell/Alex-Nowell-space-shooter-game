using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonicboomlogic : MonoBehaviour
{
    public float growSpeed = 2;
    private float cGrow;
    public float max = 5;
    private 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cGrow += growSpeed * Time.deltaTime;
        if (cGrow >= max) {
            Destroy(gameObject);
        }
        transform.localScale = Vector3.one * cGrow;
    }
}
