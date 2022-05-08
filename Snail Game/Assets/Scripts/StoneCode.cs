using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCode : MonoBehaviour
{
    private float Speed = 20.0f;
    private float BoundaryX = -40f;
    
    // Update is called once per frame
    void Update()
    {
        // Vector*Time*Meters per second
        transform.Translate(Vector3.left * Speed * Time.deltaTime);

        // if the stone reaches a certain number on the X axis it will destroy itself. This is to stop too many stones from cluttering the game
        if (transform.position.x < BoundaryX)
        {
            Destroy(gameObject);
            
        }
    }
}