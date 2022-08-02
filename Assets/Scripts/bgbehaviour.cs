using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgbehaviour : MonoBehaviour
{
    public Renderer meshrender;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = meshrender.material.mainTextureOffset;
        offset =    offset + new Vector2(0,speed*Time.deltaTime);
        meshrender.material.mainTextureOffset = offset;
    }
}
