using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        //문자열(string)에 숫자가 아닌 데이터가 들어있을 경우 숫자로 형 변환을 시도하면 에러가 발생한다.
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
		Debug.Log("floatValue : " + floatValue);
		Debug.Log("stringValue : " + stringValue);

        //33.4567과 같은 실수를 int로 형변환을 시도하면 에러 발생
        intValue = int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue = float.Parse(stringValue);

		Debug.Log("intValue : " + intValue);
		Debug.Log("floatValue : " + floatValue);
		Debug.Log("stringValue : " + stringValue);
	}
}
