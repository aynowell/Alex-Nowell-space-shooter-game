using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject Projectil;
    public Transform barrel;
    public float frequency = 0.5f;
    private float Ctime;
    public bool specialshooting;
    private int specialshootingTimes;
    public GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        crosshair.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (specialshooting) { 
            Vector3 msPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            crosshair.transform.position = msPosition;
            Vector3 lookAt = msPosition;
            float angleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);
            float angleDeg = (180/Mathf.PI)*angleRad;
            transform.rotation = Quaternion.Euler(0, 0, angleDeg + 270);

            

             if (Input.GetMouseButtonDown(0))
            {
                GameObject clone = Instantiate(Projectil, barrel.position, barrel.rotation);
                Destroy(clone, 3);
                Ctime = 0;
                specialshootingTimes += 1;
                if (specialshootingTimes >= 3) {
                    specialshooting = false;
                    specialshootingTimes = 0;
                }
            }
        }
        else
        {
            if (Ctime >= frequency)
            {
                if (Input.GetKey(KeyCode.Space))
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
}
