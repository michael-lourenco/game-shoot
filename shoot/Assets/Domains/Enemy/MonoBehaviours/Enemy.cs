using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //collision.gameObject.SendMessage("ApplyDamage", 10);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            //collision.gameObject.SendMessage("ApplyDamage", 10);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
