using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, cell_mirror, sheets_0, lock_0, sheets_1, lock_1, corridor_0};
	private States myState;

	// Use this for initialization
	void Start () {myState = States.cell;}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);	
		if 		(myState == States.cell) 		{cell ();} 
		else if (myState == States.sheets_0) 	{sheets_0 ();} 
		else if (myState == States.lock_0) 		{lock_0 ();} 
		else if (myState == States.mirror) 		{mirror ();} 
		else if (myState == States.cell_mirror) {cell_mirror (); } 
		else if (myState == States.sheets_1) 	{sheets_1 ();} 
		else if (myState == States.lock_1) 		{lock_1 ();} 
		else if (myState == States.corridor_0)  {corridor_0 ();}
	}

	#region State Handler Methods
	void cell ()
	{
		text.text = "You begin to blink your eyes as the cold wet water drips on your forehead. " +
					"As your feet hit the cold floor, you look around to notice you're in a prison cell. " +
					"You're not sure how you got here, but you do notice some dirty sheets, a mirror, and a door " +
					"which is locked from the outside.\n\n" +
					"Press S to view Sheets, \nPress M to view Mirror, \nPress L to view Lock";
		print (text.text);
		if 		(Input.GetKeyDown (KeyCode.S)) 			{myState = States.sheets_0;} 
		else if (Input.GetKeyDown (KeyCode.M)) 			{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 			{myState = States.lock_0;};
	}

	void sheets_0 ()
	{
		text.text = "You're confused as to why anyone would ever want to sleep in these. " + 
					"But I guess it's as good as it gets. " + 
					"\n\nPress R to Return to roaming your cell.";
		print (text.text);
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;} 
	}

	void lock_0 ()
	{
		text.text = "What a dingy lock! It's one of those new button-combination locks of course, " +  
					"and there's just no way to see the fingerprints on the lock...or is there?" + 
					"\n\nPress R to Return to roaming your cell.";
		print (text.text);
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;} 
	}

	void mirror ()
	{
		text.text = "You find a mirror in desperate need of cleaning. You try to polish it with the torn " + 
					"corner of your shirt, and with limited success you begin to see your terribly bruised face. " + 
					"Maybe you shouldn't have cleaned the mirror after all." + 
					"\n\n Press T to Take the mirror";
		print (text.text);
		if (Input.GetKeyDown (KeyCode.T)) 		{myState = States.cell_mirror;} 
	}

	void cell_mirror () 
	{
		text.text = "You are STILL in your cell and you STILL want to escape, but now I guess you can see " + 
					"your miserable reflection. Around you are those dirty sheets on the bed, the only clean spot " + 
					"where the mirror once was, and the door. Still locked, still unopened. If only you could look " + 
					"at the outside of the door where the keypad is" + 
					"\n\nPress S to look at the Sheets\n\nPress L to look at the Lock";
		if 		(Input.GetKeyDown (KeyCode.S)) 	{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.L))  {myState = States.lock_1;}  
	}

	void sheets_1 ()
	{
		text.text = "No...just, no. Would it kill them to get a little housekeeping in here?" +
					"\n\nPress R to Return to the cell";
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;};
	}

	void lock_1 ()
	{
		text.text = "As fate would have it, by putting your hand through the small gap in the window bars, " + 
					"you can just barely make out the dirty fingerprints on the lock. After trying a few of the "  + 
					"combinations, you hear a click in the lock" + 
					"\n\nPress O to Open the door\n\nPress R to Return to your cell";
		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell_mirror;} 
		else if (Input.GetKeyDown (KeyCode.O))  {myState = States.corridor_0;};
	}

	void corridor_0 ()
	{
		text.text = "The cool night air washes over you as you breath in what feels like the first breath " +
					"you've taken in years. But it's probably good to not stay around too long, just in case your " +
					"captors are wondering what that noise was (hint: you may have screamed as you opened the door)." +
					"\n\nYou wish you were free, but the story's only just begun..." + 
					"\n\nYou are in a long corridor...\n\nPress P to Play again";
		if (Input.GetKeyDown (KeyCode.P)) 		{myState = States.cell;};
	}
	#endregion
}