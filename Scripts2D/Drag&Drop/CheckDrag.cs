using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDrag : MonoBehaviour
{
    static public int count = 0;
    public bool check_drag;
    public bool drop;
    public bool back_to_start_position;
    public string drag_object;
    private Vector3 start_position;
    public GameObject no_drop;
    public GameObject ButtonNext;

    void Start()
    {
        drop = true;
        check_drag = false;
        start_position = transform.position;
        ButtonNext.SetActive(false);
    }

    public void DestroyNoDrop()
    {
        GameObject no_drop = GameObject.FindGameObjectWithTag("NoDrop");
        Destroy(no_drop);
    }

    public void OnCollisionStay2D(Collision2D collision2D)
    {
        if (check_drag)
        {
            if (collision2D.gameObject.name == drag_object)
            {
                Destroy(gameObject);
                count++;
                if (count == 16)
                    ButtonNext.SetActive(true);
                return;
            }

            if (back_to_start_position)
            {
                transform.position = start_position;
            }
        }

        if (collision2D.gameObject.name != drag_object && drop)
        {
            Instantiate(no_drop, transform.position, transform.rotation);
            drop = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision2D)
    {
        DestroyNoDrop();
        drop = true;
    }

}