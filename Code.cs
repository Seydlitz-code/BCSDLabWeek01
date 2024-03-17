using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;
        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        intValue = 130;
		//int   -2147483648 ~ 2147483647;
        //sbyte   -128 ~ 127
		sbyteValue = (sbyte)intValue;
		//sbyte의 최대 범위인 127보다 큰 130을 전달했기 때문에 오버플로우 발생
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("intValue : " + intValue);
	}
}
