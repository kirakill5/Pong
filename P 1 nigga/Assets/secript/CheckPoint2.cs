using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2 : MonoBehaviour
{

    public int a;
    public int b;

    public void Start ()
    {
       Debug.Log(Sum(a, b));
       Debug.Log(Prod(a, b)); 
       Debug.Log(div(a, b));
    }

    float Sum(float a, float b)
    {
        return a + b;
    }
    float Prod(float a, float b)
    {
        return a * b;
    }
    float div(float a, float b)
    {
        if (b != 0)
        {
            return a /b;
        }
        else
        {
            Debug.Log("an error");
            return 0;
        }
    }

}

  
