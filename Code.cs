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
				Debug.Log("�÷��̾� ���� : ���");
				break;
			case PlayerMove: 
				Debug.Log("�÷��̾� ���� : �̵�");
				break;
			case PlayerAttack:
				Debug.Log("�÷��̾� ���� : ����"); // �ùٸ� Debug.Log ȣ��
				break;
		}
	}
}
