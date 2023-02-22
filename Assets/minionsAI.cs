using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minionsAI : MonoBehaviour
{
    public GameObject Projectil;
    public Transform[] barrels;
    public float frequency = 0.5f;
    private float Ctime;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,120);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ctime >= frequency)
        {
            foreach (Transform barrel in barrels)
            {
                GameObject clone = Instantiate(Projectil, barrel.position, barrel.rotation);
                Destroy(clone, 3);
                Ctime = 0;

            }
           
        }
        else
        {
            Ctime += Time.deltaTime;
        }
    }
}
