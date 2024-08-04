using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseButtons2 : MonoBehaviour
{
    public GameObject laser_place;
    public GameObject laser;
    private Vector3 laser_offset;

    private bool can_shoot;
    void Start()
    {
        CursorManager.SetCursorTexture();
        CursorManager.CursorVisible();
        can_shoot = true;
        laser_offset = new Vector3(0, 0, transform.position.z);

        InvokeRepeating("CanShoot",0.1f,0.1f);
    }

    void Update()
    {

        if (Input.GetMouseButton(0) && can_shoot)
        {
            Instantiate(laser, laser_place.transform.position + laser_offset, laser_place.transform.rotation);
        }

        if (Input.GetMouseButton(1))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 0.05f * Time.deltaTime);
        }

        if (Input.GetMouseButtonUp(1))
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

    void CanShoot()
    {
        can_shoot ^= true;
    }
}

