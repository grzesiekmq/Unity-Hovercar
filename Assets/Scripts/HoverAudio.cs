using UnityEngine;
using System.Collections;

public class HoverAudio : MonoBehaviour {

	public AudioSource jetSound;
	private float jetPitch;
	private const float LowPitch = 0.1f;
	private const float HighPitch = 2.0f;
	private const float SpeedToRevs = 0.01f;
	Vector3 myVelocity;
	Rigidbody carRigidBody;

	void Awake () {
		carRigidBody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		myVelocity = carRigidBody.velocity;
		float forwardSpeed = transform.InverseTransformDirection (myVelocity).z;
		float engineRevs = Mathf.Abs (forwardSpeed) * SpeedToRevs;
		jetSound.pitch = Mathf.Clamp (engineRevs, LowPitch, HighPitch);

	}
}
