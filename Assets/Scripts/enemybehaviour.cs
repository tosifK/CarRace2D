using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehaviour : MonoBehaviour
{
    public float enemyspeed;
  //  public float maxenemyspeed;
    // Start is called before the first frame update
    void Start()
    {
       /* enemyspeed += 0.03f * Time.time;
        if(enemyspeed >= maxenemyspeed)
        {
            enemyspeed = maxenemyspeed; 
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -1)*enemyspeed*Time.deltaTime);
    }
   
}
