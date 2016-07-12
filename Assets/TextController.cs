using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Hello world";
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown("space"))
			text.text = "You begin to blink your eyes as the cold wet water drips on your forehead. " + 
						"As your feet hit the cold floor, you look around to notice you're in a prison cell. " + 
						"You're not sure how you got here, but you do notice some dirty sheets, a mirror, and a door " + 
						"which is locked from the outside.\n\n" + 
						"Press S to view Sheets, \nPress M to view Mirror, \nPress L to view Lock";
					
	
	}
}
