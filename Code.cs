using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        string stringValue = "�ʱ�ȭ";
        int intValue = 33;
        float floatValue = 12.3456f;
        Debug.Log("stringValue : " + stringValue);

        //������ ���ڿ��� �� ��ȯ
        stringValue = intValue.ToString();
		Debug.Log("stringValue : " + stringValue);

        //�Ǽ��� ���ڿ��� �� ��ȯ
        stringValue = floatValue.ToString();
		Debug.Log("stringValue : " + stringValue);
	}
}
