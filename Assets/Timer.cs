using UnityEngine;
using System.Collections;

public class Timer: MonoBehaviour 
{
	float timeRemeaning = 420;
	//float timeRemeaning = 4;
	static bool stopped = false;
	void Start(){
	}
	public static void Stop(){
		stopped = true;
	}
	void Update(){
		if (stopped == false) {
			timeRemeaning -= Time.deltaTime;
		}
	}
	void OnGUI(){
	if (timeRemeaning > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), "Time left: " + timeRemeaning);
		} else {
			GUI.Label (new Rect (100, 100, 200, 100), "Time left: " + "Time`s up");
			Application.LoadLevel(2);
		}
	}
}