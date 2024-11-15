using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] float m_Sensitivity = 1;
	[SerializeField] float m_FlyForce = 1;

	Rigidbody m_Rigidbody;

	void Awake()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		float pitch = transform.localEulerAngles.x;
		float yaw = transform.localEulerAngles.y;

		yaw += Input.GetAxisRaw("Mouse X") * m_Sensitivity;
		pitch -= Input.GetAxisRaw("Mouse Y") * m_Sensitivity;

		transform.localEulerAngles = new Vector3(pitch, yaw, 0);
	}

	void FixedUpdate()
	{
		float forwardMove = Input.GetAxisRaw("Vertical");
		float sideMove = Input.GetAxisRaw("Horizontal");

		Vector3 force = Vector3.zero;
		force += forwardMove * m_FlyForce * transform.forward;
		force += sideMove * m_FlyForce * transform.right;

		m_Rigidbody.AddForce(force, ForceMode.Acceleration);
	}
}
