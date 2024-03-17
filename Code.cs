using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        float floatValue01 = 3.141592653589793238462643383279f;
        //7자리 표현
        float floatValue02 = 31.41592653589793238462643383279f;
        //7자리 표현
        double doubleValue = 3.141592653589793238462643383279;
        //15자리 표현
        decimal decimalValue = 3.141592653589793238462643383279m;
        //29자리 표현

        Debug.Log("float Data : " + floatValue01);
		Debug.Log("float Data : " + floatValue02);
		Debug.Log("double Data : " + doubleValue);
		Debug.Log("decimal : " + decimalValue);
	}
}
