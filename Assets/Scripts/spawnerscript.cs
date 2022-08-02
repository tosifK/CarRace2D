using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject[] enemycar;
    float respawntime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Enemyspawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1,respawntime));
            spawncar();
            
        }
    }
    void spawncar()
    {
        int index = Random.Range(0, enemycar.Length);
        GameObject thiscar = Instantiate(enemycar[index],transform.position,Quaternion.identity);
        thiscar.GetComponent<SpriteRenderer>().flipX = false;
        thiscar.GetComponent<SpriteRenderer>().flipY = true;
        
    }
}
