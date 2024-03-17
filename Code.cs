using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        object valueInt = 31;
        //빅싱 (데이터 저장)
        object valueFloat = 3.14159265358979f;
        //빅싱 (데이터 저장)
        object valueString = "객체지향 프로그래밍";
        object valueBool = false;

        Debug.Log("정수 : " + valueInt);
		Debug.Log("실수 : " + valueFloat);
		Debug.Log("문자열 : " + valueString);
		Debug.Log("논리 : " + valueBool);
	}
}
