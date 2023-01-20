using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class puzzle1 : MonoBehaviour
{
    public static bool finishedPuzzle = false;

    public GameObject triggerBox;

    private bool square;
    private bool circle;
    private bool rhombus;
    private bool triangle;

    public Text squareText;
    public Text circleText;
    public Text rhombusText;
    public Text triangleText;

    // Start is called before the first frame update
    void Start()
    {
        square = false;
        circle = false;
        rhombus = false;
        triangle = false;
    }

    public void pressSquare()
    {
        square = true;
        Debug.Log("yes!");
        squareText.color = Color.green;
    }

    public void pressCircle()
    {
        if(square == true)
        {
            circle = true;
            Debug.Log("yes!");
            circleText.color = Color.green;
        }
        else
        {
            Debug.Log("no!");
            square = false;
            circle = false;
            rhombus = false;
            triangle = false;

            squareText.color = Color.red;
            circleText.color = Color.red;
            rhombusText.color = Color.red;
            triangleText.color = Color.red;

            StartCoroutine(failure());
        }
    }

    public void pressRhombus()
    {
        if (circle == true)
        {
            rhombus = true;
            Debug.Log("yes!");
            rhombusText.color = Color.green;
        }
        else
        {
            Debug.Log("no!");
            square = false;
            circle = false;
            rhombus = false;
            triangle = false;

            squareText.color = Color.red;
            circleText.color = Color.red;
            rhombusText.color = Color.red;
            triangleText.color = Color.red;

            StartCoroutine(failure());
        }
    }

    public void pressTriangle()
    {
        if (rhombus == true)
        {
            triangle = true;
            Debug.Log("yay!");
            triangleText.color = Color.green;
            triggerBox.SetActive(false);
            finishedPuzzle = true;
        }
        else
        {
            Debug.Log("no!");
            square = false;
            circle = false;
            rhombus = false;
            triangle = false;

            squareText.color = Color.red;
            circleText.color = Color.red;
            rhombusText.color = Color.red;
            triangleText.color = Color.red;

            StartCoroutine(failure());
        }
    }

    IEnumerator failure()
    {
        yield return new WaitForSeconds(1);

        squareText.color = Color.black;
        circleText.color = Color.black;
        rhombusText.color = Color.black;
        triangleText.color = Color.black;
    }
}
