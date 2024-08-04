using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    Transform this_transform;
    private GameObject player;

    public int speed;
    void Start()
    {
        this_transform = transform;
        player = GameObject.Find("Plane");
    }
    void Update()
    {
        if (player != null)
        {
            Vector3 direction = new Vector3(player.transform.position.x, player.transform.position.y, 0);
            this_transform.position = Vector3.MoveTowards(this_transform.position, direction, speed * Time.deltaTime);
        }
    }
}
