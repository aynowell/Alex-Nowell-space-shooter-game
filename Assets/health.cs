using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public float overallhealth = 10;
    private float currenthealth;
    public Image healthbar;
    public gamemanager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("manager").GetComponent<gamemanager>();
        currenthealth = overallhealth;
        if (healthbar != null)
        {
            healthbar.fillAmount = currenthealth / overallhealth;
        }
    }

    public void takedamage(float damage)
    {
        currenthealth = currenthealth - damage;
        if (healthbar != null)
        {
            healthbar.fillAmount = currenthealth / overallhealth;
        }
        if (currenthealth <= 0)
        {
            if (tag == "Enemy" || tag == "boss")
            {
                GM.enemieskilled += 1;
                if (tag == "Enemy")
                {
                    GM.money += 1;
                    GM.updateMoney();
                }
                else
                {
                    GM.money += 10;
                    GM.updateMoney();
                }
             
            }
            if (tag == "boss")
            {
                SceneManager.LoadScene("the you won screen");
            }
            if (tag == "Player") {

                SceneManager.LoadScene("the you loose screen");
            }
            Destroy(gameObject);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(tag == "Enemy" || tag == "boss")
        {
            float damage = 1;
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<shooting>().specialshooting) {
                damage = 3;
            }
            if (collision.gameObject.CompareTag("Bullet"))
            {
                takedamage(damage);
                Destroy(collision.gameObject);


            }

            if (collision.gameObject.CompareTag( "forcefield"))
            {
                Destroy(gameObject);

            }
            if (collision.gameObject.CompareTag("meteor"))
            {
                takedamage(1000000);

            }
        }



        if (tag == "Player")
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                takedamage(1);
            }
            if (collision.gameObject.CompareTag("boss"))
            {
                takedamage(3);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
