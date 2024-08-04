using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    public static  Texture2D cursor_texture = Resources.Load("cross_fire_red") as Texture2D;
    public static Vector2 hotspot = new Vector2(50, 50); 
    public static void Start()
    {
       
    }
    public static void Update()
    {
        
    }

    public static void CursorVisible()
    {
        Cursor.visible = true;
    }

    public static void CursorUnvisible()
    {
        Cursor.visible = false;
    }

    public static void CursorLocked()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void CursorUnLocked()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public static void SetCursorSystem()
    {
        Cursor.SetCursor(null, hotspot, CursorMode.Auto);
    }
    public static void SetCursorTexture()
    {
        Cursor.SetCursor(cursor_texture, hotspot, CursorMode.Auto);  
    }
}


