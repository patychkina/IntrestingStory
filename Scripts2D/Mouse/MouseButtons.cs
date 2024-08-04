using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseButtons : MonoBehaviour
{
    public GameObject bullet;
    public GameObject rocket;

    private Vector3 bullet_offset;
    private Vector3 rocket_offset_left;
    private Vector3 rocket_offset_right;
    private bool rocket_side;

    void Start()
    {
        CursorManager.CursorUnvisible();

        bullet_offset = new Vector3(0, 0.5f, 1);
        rocket_offset_left = new Vector3(-0.5f, 0, 1);
        rocket_offset_right = new Vector3(0.5f, 0, 1);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position + bullet_offset, transform.rotation);
        }

        if (Input.GetMouseButtonUp(1))
        {
            rocket_side ^= true;
            switch (rocket_side)
            {
                case true:Instantiate(rocket, transform.position + rocket_offset_left, transform.rotation); break;
                case false:Instantiate(rocket, transform.position + rocket_offset_right, transform.rotation); break;
            }
        }
    }
}


