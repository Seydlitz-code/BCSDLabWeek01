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

		// ��ȣ �ִ� ������ ������ ��
		sbyteValue = -31;
		byteValue = (byte)sbyteValue;
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("byteValue : " + byteValue);

		// ��ȣ �ִ� ������ ��ȣ ���� ������ �ִ밪���� Ŭ ��
		byteValue = 200;
		sbyteValue = (sbyte)byteValue;
		Debug.Log("sbyteValue : " + sbyteValue);
		Debug.Log("byteValue : " + byteValue);
	}
}
