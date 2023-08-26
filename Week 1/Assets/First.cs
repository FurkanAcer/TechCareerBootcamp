using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    [SerializeField] int number = 5;
    [SerializeField] float floatNumber = 2.5f;
    [SerializeField] string text = "Hello, Unity";

    void Start()
    {
        IntMethod();
        FloatMethod();
        StringMethod();
    }

    void IntMethod()
    {
        if (number > 0)
        {
            Debug.Log("Int value is positive.");
        }
        else if (number == 0)
        {
            Debug.Log("Int value is neutral.");
        }
        else
        {
            Debug.Log("Int value is non-positive.");
        }
    }

    void FloatMethod()
    {
        switch (floatNumber)
        {
            case 1.5f:
                Debug.Log("Float value is 1.5.");
                break;
            case 2.5f:
                Debug.Log("Float value is 2.5.");
                break;
            default:
                Debug.Log("Float value is not 1.5 or 2.5.");
                break;
        }
    }

    void StringMethod()
    {
        int counter = 0;
        while (counter < 3)
        {
            Debug.Log((counter +1) + ".  " + text);
            counter++;
        }
    }
}
