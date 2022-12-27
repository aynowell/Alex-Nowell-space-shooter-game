using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float speed = 6;
    public GameObject Fire;
    public float rotspeed = 180;
    public float shipBoundaryRadius = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        

        Vector3 direction = new Vector3(0, v, 0);

        if (direction == Vector3.zero)
        {
            Fire.SetActive(false);
        }
        else
        {
            Fire.SetActive(true);
        }

            transform.Translate(direction * speed * Time.deltaTime);

        Vector3 rotation = new Vector3(0, 0, -h);
        transform.Rotate(rotation * rotspeed * Time.deltaTime);


        Vector3 pos = transform.position;

        // RESTRICT the player to the camera's boundaries!

        // First to vertical, because it's simpler
        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        // Now calculate the orthographic width based on the screen ratio
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        // Now do horizontal bounds
        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        // Finally, update our position!!
        transform.position = pos;
    }
}
