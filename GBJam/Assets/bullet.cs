using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
        Debug.Log(hitInfo.gameObject.name + 'd');
        Destroy(hitInfo.gameObject);
        Score.instance.AddPoint();
    }

    void FixedUpdate()
    {
        if(rb.gameObject.transform.position.x > 8)
        {
            Destroy(rb.gameObject);
        }
    }
}
