using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackWhenAtDragon : MonoBehaviour
{
	Animator m_Animator;

	void Awake()
	{
		m_Animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Dragon")
		{
			m_Animator.SetBool("Attacking", true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Dragon")
		{
			m_Animator.SetBool("Attacking", false);
		}
	}
}
