using System.Collections.Generic;
using UnityEngine;

public class Carbehaviour : MonoBehaviour
{ 
    Vector2 Vec;
    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {
        Vec = transform.localPosition;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 6;
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * 6;
        transform.localPosition = Vec;
        boundry();

        // Road.transform.position += Vector3.down*Time.deltaTime;
    }
    void boundry()
    {
        Vector2 temp = transform.position;
        if (temp.x < -1.3f)
        {
            temp.x = -1.3f;
            transform.position = temp;
        }
        if (temp.x > 1.3f)
        {
            temp.x = 1.3f;
            transform.position = temp;
        }
        if (temp.y < -3.5f)
        {
            temp.y = -3.5f;
            transform.position = temp;
        }
        if (temp.y > 3.5f)
        {
            temp.y = 3.5f;
            transform.position = temp;
        }
    }

    
    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         Destroy(gameObject);
     }*/
}

