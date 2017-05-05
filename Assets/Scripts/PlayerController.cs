using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	private float moveHorizontal, moveVertical; 
	private float force = 1f;

	public Button Forward;
	public Button Back;
	public Button Left;
	public Button Right;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

		rb.AddForce(movement * speed);
	}

	public void forwardPress() {

		force = force + 10f;
		moveVertical += force;
	}

	public void backPress() {

		force = force + 10f;
		moveVertical -= force;
	}

	public void leftPress() {

		force = force + 10f;
		moveHorizontal -= force;
	}

	public void rightPress() {

		force = force + 10f;
		moveHorizontal += force;
	}

	public void stopForce() {

		force = 0f;
		moveVertical = 0f;
		moveHorizontal = 0f;
	}

}
