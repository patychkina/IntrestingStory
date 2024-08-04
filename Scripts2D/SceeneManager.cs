using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class SceeneManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { LoadScene("ControllMouse2D"); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { LoadScene("RotateMouse2D"); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { LoadScene("Drag&Drop");}
        if (Input.GetKeyDown(KeyCode.Alpha0)) { Exit(); }
    }

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    void Exit()
    {
        Application.Quit();
    }
}
