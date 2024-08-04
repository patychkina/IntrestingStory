using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health;
    public GameObject blast;
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) { DestroyGameObject(); }
    }

    void DestroyGameObject()
    {
        Instantiate(blast, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
