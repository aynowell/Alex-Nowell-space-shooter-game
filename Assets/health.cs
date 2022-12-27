using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float overallhealth = 10;
    private float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = overallhealth;
    }

    public void takedamage(float damage)
    {
        currenthealth = currenthealth - damage;
        if(currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == "Enemy")
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                takedamage(1);
            }
        }

        if (tag == "Player")
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                takedamage(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
