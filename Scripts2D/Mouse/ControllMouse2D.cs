using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllMouse2D : MonoBehaviour
{

    Transform this_transform;
    void Start()
    {
        this_transform = transform;
    }
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        this_transform.position = mousePosition;
    }
}
