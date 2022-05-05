using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCode : MonoBehaviour
{
    private float Speed = 10.0f;
    private float acceleration = 10.0f;
    private float maxSpeed = 60.0f;
    private float BoundaryX = -40f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Move Vehicle Forward
        // Vector*Time*Meters per second
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        Speed += acceleration * Time.deltaTime;
        if (Speed > maxSpeed)
            Speed = maxSpeed;
            
        if (transform.position.x < BoundaryX)
        {
            Destroy(gameObject);
        }
    }
}