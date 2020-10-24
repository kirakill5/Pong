//This is the ball script
using UnityEngine;
using System.Collections;

public class PongBall : MonoBehaviour {
    public float speed = 31;

    void Start() {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}