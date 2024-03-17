using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("inValue : " + intValue);
        
        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("inValue : " + intValue);
	}
}
