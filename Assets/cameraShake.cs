using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	Transform camTransform;

	Vector3 offset = Vector3.zero;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 4.7f;

	Vector3 originalPos;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void Start()
	{
		originalPos = camTransform.localPosition;
		InvokeRepeating ("cameraSway", 0, 4);
	}

	void cameraSway(){
		offset = Random.insideUnitSphere * shakeAmount;
	}

	void Update(){
		camTransform.localPosition = Vector3.Slerp (originalPos, originalPos + offset, Time.deltaTime/100);
		transform.LookAt (Vector3.zero);
	}
}
