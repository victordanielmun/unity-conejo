using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject dust;

    private void FixedUpdate()
    {
        transform.Rotate(0,0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        else if(collision.gameObject.tag == "Ground")
        {
            GameObject dustEffect = Instantiate(dust, transform.position, Quaternion.identity);
            
            Destroy(dustEffect, 2f);
            Destroy(gameObject, 2f);
        }
    }
}
