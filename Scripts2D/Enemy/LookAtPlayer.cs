using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public int rotate_angle;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Plane");
    }
    void Update()
    {
        Vector3 difference = player.transform.position - transform.position;
        difference.Normalize();

        float z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, z + rotate_angle);
    }
}
