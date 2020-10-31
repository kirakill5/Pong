//This is the ball script
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PongBall : MonoBehaviour {
    
    public float speed = 31;

    public Text scorerightText;
    public Text scoreleftText;
    public Text Textloserright;
    public Text Textloserleft;
    int scoreright;
    int scoreleft;




    void Start() 
    {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

    }


    void OnCollisionEnter2D(Collision2D col)
    {


        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider

        // Hit the left Racket?
        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        //     for calculating  and printing the score
        if (col.gameObject.name == "Wallright")
        {
            scoreleft++;         // to add 1 point to the left player score
            scoreleftText.text = scoreleft.ToString();     	//this line will convert the int score variable to a string variable
        }
        if (col.gameObject.name == "Wallleft")
        {
            scoreright++;
            scorerightText.text = scoreright.ToString();    
        }

        if (scoreleft >= 10)
        {
            Textloserright.text = "ur a loser >>";
        }
        if (scoreright >= 10)
        {
            Textloserleft.text = "<< ur a loser";
        }

    }




    float hitFactor(Vector2 ballPos, Vector2 racketPos,
        float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;

    }





}