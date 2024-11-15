using System.Collections;
using System.Collections.Generic;
using DitzelGames.FastIK;
using UnityEngine;

public class Gimme : MonoBehaviour
{
	[SerializeField] FastIKFabric m_FastIK;
	[SerializeField] float m_Range = 1;

	void FixedUpdate()
	{
		if (Vector3.Distance(m_FastIK.transform.position, transform.position) < m_Range)
		{
			m_FastIK.enabled = true;
		}
		else
		{
			m_FastIK.enabled = false;
		}
	}
}
