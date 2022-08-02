using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject homescreen;
    public GameObject currentscreen;
    public GameObject overscreen;
    public GameObject pausescreen;
            
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        overscreen.gameObject.SetActive(true);
        currentscreen.gameObject.SetActive(false);

    }
    
    public void pause()
    {
        Time.timeScale = 0;
        currentscreen.gameObject.SetActive(false);
        pausescreen.gameObject.SetActive(true);

    }
    
}
