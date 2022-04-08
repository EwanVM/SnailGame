using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailBehavior : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public float zRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * -horizontalInput);
        forwardInput = Input.GetAxis("Vertical");
        
        
        transform.Translate(Vector3.left * Time.deltaTime * speed * -forwardInput); //issuw with this line

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

    }
}
