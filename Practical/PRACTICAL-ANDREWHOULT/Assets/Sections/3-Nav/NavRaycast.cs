using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavRaycast : MonoBehaviour
{
	[SerializeField] NavMeshAgent m_Agent;

	[SerializeField] LayerMask m_LayerMask;

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
			if (Physics.Raycast(ray, out RaycastHit hit, 1000, m_LayerMask, QueryTriggerInteraction.Ignore))
			{
				m_Agent.SetDestination(hit.point);
			}
		}
	}
}
