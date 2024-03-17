using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        string stringValue = "숫자가 아닙니다.";
        int intValue = 10;
		bool isConversion = int.TryParse(stringValue, out intValue);
		if (isConversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
			Debug.Log("intValue : " + intValue);
		}
        else
        {
			Debug.Log("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형 변환에 실패했습니다.");
		}
    }
}
