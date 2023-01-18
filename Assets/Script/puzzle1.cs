using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle1 : MonoBehaviour
{
    private bool square;
    private bool circle;
    private bool rhombus;
    private bool triangle;

    // Start is called before the first frame update
    void Start()
    {
        square = false;
        circle = false;
        rhombus = false;
        triangle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressSquare()
    {
        square = true;
        Debug.Log("yes!");
    }

    public void pressCircle()
    {
        if(square == true)
        {
            circle = true;
            Debug.Log("yes!");
        }
        else
        {
            Debug.Log("no!");
        }
    }

    public void pressRhombus()
    {
        if (circle == true)
        {
            rhombus = true;
            Debug.Log("yes!");
        }
        else
        {
            Debug.Log("no!");
        }
    }

    public void pressTriangle()
    {
        if (rhombus == true)
        {
            triangle = true;
            Debug.Log("yay!");
        }
        else
        {
            Debug.Log("no!");
        }
    }
}
