using UnityEngine;
using System.Collections;

public class ResetManager : MonoBehaviour {
	
	public GameObject player;
	public Font font;
	
	private bool isRPressed = false;
	private GUIStyle style;
	private bool isPaused = false;

	Vector3 startingPosition;
	Quaternion startingRotation;

	void Start() {
		startingPosition = player.transform.position;
		startingRotation = player.transform.rotation;
		style = new GUIStyle ();
		style.fontSize = 40;
		style.font = font;
		style.normal.textColor = Color.white;
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.R) && !isPaused) {
			if (isRPressed) {
				isRPressed = false;
			} else {
				isRPressed = true;
			}
		}
		if (Input.GetKeyDown (KeyCode.N) && !isPaused) {
			isRPressed = false;
		}
		if (Input.GetKeyDown (KeyCode.Y) && isRPressed && !isPaused) {
			player.transform.position = startingPosition;
			player.transform.rotation = startingRotation;
			isRPressed = false;
		}
		
	}	

	void OnGUI (){
		if (isRPressed) {	
			GUI.Label (new Rect (Screen.width / 2.2f, Screen.height / 2.2f, 100, 50), "Reset? y/n", style);
		}
	}
}
