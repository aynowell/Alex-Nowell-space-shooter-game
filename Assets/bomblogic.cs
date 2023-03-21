using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomblogic : MonoBehaviour
{
    public Vector3 offset;
    public float explosionRadius;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 msPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        msPosition.z = 0;
        transform.position = msPosition + offset;
        if (Input.GetMouseButton(0)) {
            Collider2D[] victims = Physics2D.OverlapCircleAll(transform.position, explosionRadius);
            foreach(Collider2D victim in victims)
            {
                if(victim.tag == "Enemy")
                {
                    victim.GetComponent<health>().takedamage(1234567); 
                }
            }
            Destroy(gameObject);
        }
    }
}
