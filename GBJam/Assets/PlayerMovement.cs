using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] public float speed = 250;

    private float movement = 0;

    private Rigidbody2D rb;

    void Start()
    {
        // Get component references
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(
            0, 
            movement * speed * Time.deltaTime
        );
    }
}
