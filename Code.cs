using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        float floatValue01 = 3.141592653589793238462643383279f;
        //7�ڸ� ǥ��
        float floatValue02 = 31.41592653589793238462643383279f;
        //7�ڸ� ǥ��
        double doubleValue = 3.141592653589793238462643383279;
        //15�ڸ� ǥ��
        decimal decimalValue = 3.141592653589793238462643383279m;
        //29�ڸ� ǥ��

        Debug.Log("float Data : " + floatValue01);
		Debug.Log("float Data : " + floatValue02);
		Debug.Log("double Data : " + doubleValue);
		Debug.Log("decimal : " + decimalValue);
	}
}
