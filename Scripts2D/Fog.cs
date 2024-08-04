using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    public int[] speed = new int[3];
    public GameObject [] fog = new GameObject[3];

    private float [] x = new float[50];
    private float [] y = new float[50];
    private int [] fog_speed = new int[50];
    private GameObject [] fogs = new GameObject[50]; 
    void Start()
    {
        for (int i = 0; i < x.Length; i++)
        {
            int index = Random.Range(0, 3);
            x[i] = Random.Range(0, Screen.width);
            y[i] = Random.Range(0, Screen.height);
            fog_speed[i] = speed[index];
        }

        for (int i = 0; i < x.Length; i++)
        {
            int index = Random.Range(0,3);
            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x[i], y[i], Camera.main.nearClipPlane));
            fogs[i] = Instantiate(fog[index], position, transform.rotation);
        }
    }
   
    void Update()
    {
        for (int i = 0; i < y.Length; i++)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x[i], y[i], Camera.main.nearClipPlane));

            y[i] -= fog_speed[i] * Time.deltaTime;
            if (y[i] < -150)
            {
              y[i] = Screen.height + 150; position = Camera.main.ScreenToWorldPoint(new Vector3(x[i], y[i], Camera.main.nearClipPlane));
             
            }
            fogs[i].transform.position = position;
        }
    }
}
