using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);	
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.cell) {
			state_sheets_0 ();
		}
	}
	void state_cell ()
	{
		text.text = "You begin to blink your eyes as the cold wet water drips on your forehead. " +
			"As your feet hit the cold floor, you look around to notice you're in a prison cell. " +
			"You're not sure how you got here, but you do notice some dirty sheets, a mirror, and a door " +
			"which is locked from the outside.\n\n" +
			"Press S to view Sheets, \nPress M to view Mirror, \nPress L to view Lock";
		print (text.text);
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} 
	}

	void state_sheets_0 ()
	{
		text.text = "You're confused as to why anyone would ever want to sleep in these. " + 
			"But I guess it's as good as it gets. " + 
			"\n\nPress R to Return to roaming your cell.";
		print (text.text);
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} 
	}

}
