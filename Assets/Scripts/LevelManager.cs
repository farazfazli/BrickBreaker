using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static int number = 1;
	
	public void startLevel(string level) {
		print ("Starting: " + level);
		number = int.TryParse (level.Substring(level.Length-1), out number) ? number : 0;
		Application.LoadLevel (level);
	}
	
	public void quitRequest() {
		print ("Quitting game!");
		Application.Quit ();
	}
	
	public void loadNextLevel() {
		print (number);
		number++;
		if (number < 10) {
		Application.LoadLevel ("Level_0" + number);
		} else if (number >= 10 || number <= 99) {
		Application.LoadLevel ("Level_" + number);
		}
	}
}
