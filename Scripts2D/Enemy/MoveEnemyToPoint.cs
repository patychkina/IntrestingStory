using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyToPoint : MonoBehaviour
{

    Transform this_transform;

    private float speed;
    void Start()
    {
        speed = Random.value  * 2;
        this_transform = transform;
    }
    void Update()
    {
        this_transform.position = Vector3.MoveTowards(this_transform.position, new Vector3(0,0,0), speed * Time.deltaTime);
    }
}
