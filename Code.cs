using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        //���ڿ�(string)�� ���ڰ� �ƴ� �����Ͱ� ������� ��� ���ڷ� �� ��ȯ�� �õ��ϸ� ������ �߻��Ѵ�.
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
		Debug.Log("floatValue : " + floatValue);
		Debug.Log("stringValue : " + stringValue);

        //33.4567�� ���� �Ǽ��� int�� ����ȯ�� �õ��ϸ� ���� �߻�
        intValue = int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue = float.Parse(stringValue);

		Debug.Log("intValue : " + intValue);
		Debug.Log("floatValue : " + floatValue);
		Debug.Log("stringValue : " + stringValue);
	}
}
