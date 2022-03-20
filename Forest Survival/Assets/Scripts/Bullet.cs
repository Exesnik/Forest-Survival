using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]

public class Bullet : MonoBehaviour
{

	void Start()
	{
		// ���������� ������ �� ��������� ���������� ������� (������), ���� ���� ������ �� ������
		Destroy(gameObject, 20);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (!coll.isTrigger) // ����� ���� �� ����������� �� �������
		{
			switch (coll.tag)
			{
				case "Enemy_1":
					// ���-��...
					break;
				case "Enemy_2":
					// ���-�� ���...
					break;
			}

			Destroy(gameObject);
		}
	}





}
