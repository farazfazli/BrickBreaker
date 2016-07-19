using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	void Update () {
		float position = Input.mousePosition.x / Screen.width * 16;
		this.transform.position = new Vector3(Mathf.Clamp (position, .75f, 15.25f), 0.8f, 0f);
	}
}
