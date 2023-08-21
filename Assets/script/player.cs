using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    float x;
    public int impulso;
    bool impulsinar;
    int velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            impulsinar = true;
        }
    }
    private void FixedUpdate()
    {
        if (impulsinar)
        {
            rb.velocity = new Vector2(rb.velocity.x,impulso);
            impulsinar= false;
        }
        rb.velocity = new Vector2(x*velocidade,rb.velocity.y);

        
    }
}
