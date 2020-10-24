using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Vector2 speed;
    // Update is called once per frame
    void Update()
    {
        Vector2 speed = new Vector2(12, 3);
        GetComponent<Rigidbody2D>().velocity = speed;
    }
 
}
