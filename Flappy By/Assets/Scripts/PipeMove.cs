using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    float speed = 5f;
    float leftScreen;
    void Start()
    {
        leftScreen = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftScreen)
        {
            Destroy(gameObject);
        }
    }
}
