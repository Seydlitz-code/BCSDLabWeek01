using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
	private void Awake()
	{
		sbyte sbyteValue = 31;
		byte byteValue = (byte)sbyteValue;
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("byteValue : " + byteValue);

		// 부호 있는 정수가 음수일 때
		sbyteValue = -31;
		byteValue = (byte)sbyteValue;
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("byteValue : " + byteValue);

		// 부호 있는 정수가 부호 없는 정수의 최대값보다 클 때
		byteValue = 200;
		sbyteValue = (sbyte)byteValue;
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("byteValue : " + byteValue);
	}
}
