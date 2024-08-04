using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyOutScreen : MonoBehaviour
{

    public GameObject [] asteroid = new GameObject[3];

    public float period;

    public bool left_side_screen;
    public bool right_side_screen;
    public bool top_side_screen;
    public bool bottom_side_screen;

    void Start()
    {
        InvokeRepeating("CreateEnemy", 1f, period);
    }

    void Update()
    {
        
    }

    void CreateEnemy()
    {
        if (left_side_screen)   { LeftSideScreen(); }
        if (right_side_screen)  { RightSideScreen(); }
        if (top_side_screen)    { TopSideScreen(); }
        if (bottom_side_screen) { BottomSideScreen(); }
    }

    void LeftSideScreen()
    {
        int x = 0;
        int y = 0;
        int index_asteroid = Random.Range(0, 3);
        x = Random.Range(-200, 0); y = Random.Range(0, Screen.height);
        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 2));
        Instantiate(asteroid[index_asteroid], position, transform.rotation);
    }

    void RightSideScreen()
    {
        int x = 0;
        int y = 0;
        int index_asteroid = Random.Range(0, 3);
        x = Random.Range(Screen.width, Screen.width + 200); y = Random.Range(0, Screen.height);
        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 2));
        Instantiate(asteroid[index_asteroid], position, transform.rotation);
    }

    void TopSideScreen()
    {
        int x = 0;
        int y = 0;
        int index_asteroid = Random.Range(0, 3);
        x = Random.Range(0, Screen.width); y = Random.Range(Screen.height, Screen.height + 200);
        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 2));
        Instantiate(asteroid[index_asteroid], position, transform.rotation);
    }

    void BottomSideScreen()
    {
        int x = 0;
        int y = 0;
        int index_asteroid = Random.Range(0, 3);
        x = Random.Range(0, Screen.width); y = Random.Range(-200, 0);
        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 2));
        Instantiate(asteroid[index_asteroid], position, transform.rotation);
    }
}
