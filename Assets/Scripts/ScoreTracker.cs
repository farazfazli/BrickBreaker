using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreTracker : MonoBehaviour {
	private static int totalBricks = 0;
	private static int totalBricksDestroyed = 0;
	
	void Start () {
		totalBricks = GameObject.FindObjectsOfType<Brick>().Length;
	}
	
	public static void incrementBricksDestroyedCount() {
		totalBricksDestroyed++;
		GameObject.Find("Text").GetComponent<Text>().text = totalBricksDestroyed.ToString ();
		if (totalBricksDestroyed >= totalBricks) {
			resetAll();
			Application.LoadLevel ("Win");
		}
	}
	
	public static void resetAll() {
		totalBricks = 0;
		totalBricksDestroyed = 0;
	}
}
