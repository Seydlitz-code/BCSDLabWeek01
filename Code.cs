using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
	private void Awake()
	{
		const int PlayerIdle = 0;
		const int PlayerMove = 1;
		const int PlayerAttack = 2; 
		int playerState = PlayerAttack;
		switch (playerState)
		{
			case PlayerIdle: 
				Debug.Log("플레이어 상태 : 대기");
				break;
			case PlayerMove: 
				Debug.Log("플레이어 상태 : 이동");
				break;
			case PlayerAttack:
				Debug.Log("플레이어 상태 : 공격"); // 올바른 Debug.Log 호출
				break;
		}
	}
}
