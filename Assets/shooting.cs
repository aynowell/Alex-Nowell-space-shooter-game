using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject Projectil;
    public Transform barrel;
    public float frequency = 0.5f;
    private float Ctime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Ctime >= frequency)
        {
            if (Input.GetKeyDown(KeyCode.Space))
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
