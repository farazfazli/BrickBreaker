using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	bool gameStarted = false;
	bool laserActivated = false;

	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	void Update () {
	if (gameStarted == false) {
		this.transform.position = paddle.transform.position + paddleToBallVector;	
	}
	if (Input.GetMouseButtonDown (0) && gameStarted == false) {
		gameStarted = true;
		this.rigidbody2D.velocity = new Vector2(2f, 10f);
		} else if (Input.GetMouseButtonDown(0) && laserActivated) {
		// Fire if powerup activated
	}
	}
}
