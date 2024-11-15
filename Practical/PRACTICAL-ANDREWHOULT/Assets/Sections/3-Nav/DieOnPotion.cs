using UnityEngine;

public class DieOnPotion : MonoBehaviour
{
	Animator m_Animator;

	void Awake()
	{
		m_Animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Potion")
		{
			m_Animator.SetTrigger("Die");
		}
	}
}
