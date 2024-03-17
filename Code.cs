using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        string stringValue = "초기화";
        int intValue = 33;
        float floatValue = 12.3456f;
        Debug.Log("stringValue : " + stringValue);

        //정수를 문자열로 형 변환
        stringValue = intValue.ToString();
		Debug.Log("stringValue : " + stringValue);

        //실수를 문자열로 형 변환
        stringValue = floatValue.ToString();
		Debug.Log("stringValue : " + stringValue);
	}
}
