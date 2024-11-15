using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentWalk : MonoBehaviour
{
	NavMeshAgent m_Agent;
	Animator m_Animator;

	void Awake()
	{
		m_Agent = GetComponent<NavMeshAgent>();
		m_Animator = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		bool walking = m_Agent.velocity.magnitude > 0.2f;

		m_Animator.SetBool("Walking", walking);
	}
}
