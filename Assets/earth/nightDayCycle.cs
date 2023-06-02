using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class nightDayCycle : MonoBehaviour {

	public float speed = 10f;

	[HideInInspector]
	public bool clockwise = true;

	// Update is called once per frame
	void Update() {


		if (clockwise) {
			transform.parent.transform.Rotate(Vector3.up, speed * Time.deltaTime);
		} else {
			transform.parent.transform.Rotate(-Vector3.up, speed * Time.deltaTime);
		}
	}
}