using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("paredeE"))
        {
            transform.position = new Vector2(transform.position.x + 18, transform.position.y);
        }
        if (collision.gameObject.tag == ("paredeD"))
        {
            transform.position = new Vector2(transform.position.x + -18, transform.position.y);
        }
        if (collision.gameObject.tag == ("paredeI"))
        {
            transform.position = new Vector2(transform.position.x , transform.position.y+12);
        }
        if (collision.gameObject.tag == ("paredeS"))
        {
            transform.position = new Vector2(transform.position.x , transform.position.y-13);
        }
    }
}
