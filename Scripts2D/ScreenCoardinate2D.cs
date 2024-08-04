using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCoardinate2D : MonoBehaviour
{
    public int x;
    public int y;
    void Start()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, transform.position.z));
    }

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, transform.position.z));
    }
}
