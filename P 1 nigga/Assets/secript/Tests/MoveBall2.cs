using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall2 : MonoBehaviour
{
    float gravity = 0f;
    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}

