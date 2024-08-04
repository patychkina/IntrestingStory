using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWithEnemy : MonoBehaviour
{

    public GameObject blast;
    void Start()
    {
        
    }

    void RestartScene()
    {
        SceeneManager.RestartScene();
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Instantiate(blast, transform.position, transform.rotation);
            Invoke("RestartScene", 5f);
        }
    }
}
