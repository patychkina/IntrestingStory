using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    Transform this_transform;
    private Vector3 offset;

    void Start()
    {
        CursorManager.SetCursorSystem();
        CursorManager.CursorVisible();
        this_transform = transform;
    }
    private void OnMouseDown()
    {
        Vector3 mouse_position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, this_transform.position.z);
        offset = this_transform.position - Camera.main.ScreenToWorldPoint(mouse_position);
        gameObject.GetComponent<CheckDrag>().drop = true;
        gameObject.GetComponent<CheckDrag>().check_drag = false;
    }

    private void OnMouseUp()
    {
        gameObject.GetComponent<CheckDrag>().check_drag = true;
        gameObject.GetComponent<CheckDrag>().DestroyNoDrop();
    }

    private void OnMouseDrag()
    {
        Vector3 mouse_position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, this_transform.position.z);
        this_transform.position = Camera.main.ScreenToWorldPoint(mouse_position) + offset;

    }

}
