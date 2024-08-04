using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyDirection : MonoBehaviour
{
    public float speed;

    public bool right;
    public bool left;
    public bool up;
    public bool down;

    private bool can_move;
    void Start()
    {
        can_move = true;
        if (Random.Range(0,2) == 0 ) { Invoke("EnableEnemy",Random.Range(1,5)); }
    }

    void Update()
    {
        if (can_move)
        {
            if (right) { transform.position += Vector3.right * speed * Time.deltaTime; }
            if (left) { transform.position += Vector3.left * speed * Time.deltaTime; }
            if (up) { transform.position += Vector3.up * speed * Time.deltaTime; }
            if (down) { transform.position += Vector3.down * speed * Time.deltaTime; }
        }
    }

    private void EnableEnemy()
    {
        GetComponent<LookAtPlayer>().enabled = true;
        GetComponent<MoveToPlayer>().enabled = true;
        can_move = false;
    }
}
