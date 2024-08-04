using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWeapon : MonoBehaviour
{

    public float speed;
    public float damage;
    void Start()
    {
       
    }
    
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Enemy")
        {
            collider2D.GetComponent<EnemyHealth>().health -= damage;
            Destroy(gameObject);
        }
    }
}
