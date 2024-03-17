using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
	private void Awake()
	{
		sbyte byteValue = -128;
		// -128 ~ 127;
		byte ubyteValue = 255;
		// 0 ~ 255;
		short shortValue = -32768;
		// -32768 ~ 32767
		ushort ushortValue = 65535;
		// 0 ~ 65535
		int intValue = -2147483648;
		// -2147483648 ~ 2147483647
		uint uintValue = 4294967295;
		// 0 ~ 4294967295
		long longValue = -9223372036854775808;
		// -9223372036854775808 ~ 9223372036854775807
		ulong ulongValue = 18446744073709551615;
		// 0 ~ 18446744073709551615
		char charValue = 'k';

		Debug.Log("sbyte Data : " + byteValue);
		Debug.Log("byte Data : " + ubyteValue);
		Debug.Log("short Data : " + shortValue);
		Debug.Log("ushort Data : " + ushortValue);
		Debug.Log("int Data : " + intValue);
		Debug.Log("uint Data : " + uintValue);
		Debug.Log("long Data : " + longValue);
		Debug.Log("ulong Data : " + ulongValue);
		Debug.Log("char Data : " + charValue);
	}
}
