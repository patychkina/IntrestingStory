using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSpeed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        gameObject.GetComponent<Animator>().speed = speed;
    }
}
