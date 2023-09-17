using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * -1 * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(rb.gameObject);
    }
    void FixedUpdate()
    {
        if(rb.gameObject.transform.position.x < -10)
        {
            Destroy(rb.gameObject);
        }
    }
}

