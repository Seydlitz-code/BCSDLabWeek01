using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        object valueInt = 31;
        //��� (������ ����)
        object valueFloat = 3.14159265358979f;
        //��� (������ ����)
        object valueString = "��ü���� ���α׷���";
        object valueBool = false;

        Debug.Log("���� : " + valueInt);
		Debug.Log("�Ǽ� : " + valueFloat);
		Debug.Log("���ڿ� : " + valueString);
		Debug.Log("�� : " + valueBool);
	}
}
