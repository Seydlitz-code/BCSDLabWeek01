using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        string stringValue = "���ڰ� �ƴմϴ�.";
        int intValue = 10;
		bool isConversion = int.TryParse(stringValue, out intValue);
		if (isConversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
			Debug.Log("intValue : " + intValue);
		}
        else
        {
			Debug.Log("stringValue ������ ����ִ� ������ ���ڰ� �ƴϾ �� ��ȯ�� �����߽��ϴ�.");
		}
    }
}
