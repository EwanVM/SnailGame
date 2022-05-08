using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailBehavior : MonoBehaviour
{
    public float speed = 15.0f;
    private float zRange = 12;
    private float forwardInput;
    
    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        // Makes the snail move up and dowm
        transform.Translate(Vector3.left * Time.deltaTime * speed * -forwardInput); 
        // Adds boundaries so the snail cant fall of the world
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

    }

    public void OnCollisionEnter(Collision collision)
    { // when the snail collides with a stone it will destroy the snail
        if (collision.collider.gameObject.CompareTag("stone"))
        {
            Destroy(gameObject);
            
            
        }
    }
}
