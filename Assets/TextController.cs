using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	public enum States {room_1, window, alleyway, piece_of_paper, room_2, room_3, room_4, storage, corridor, stairs};
	private States mystate;	
	// Use this for initialization
	
	void Start () {
		mystate = States.room_1;
	}
	
	// Update is called once per frame
	void Update () {
		print (mystate);		
		if (mystate == States.room_1)							{state_room_1();}
		else if (mystate == States.window)						{state_window();}
		else if (mystate == States.alleyway)					{state_alleyway();}
		else if (mystate == States.piece_of_paper)				{state_piece_of_paper();}
		else if (mystate == States.room_2)						{state_room_2();}
		else if (mystate == States.room_3)						{state_room_3();}
		else if (mystate == States.room_4)						{state_room_4();}
		else if (mystate == States.storage)						{state_storage();}
		else if (mystate == States.corridor)					{state_corridor();}
		else if (mystate == States.stairs)						{state_stairs();}
		
	}
	
	void state_stairs(){
		text.text = "r2" +
					"\n\n" +
					"you are in 2nd floor now " ;
	}
	
	void state_corridor(){
		text.text = "c" +
					"\n\n" +
					"Press S to go down through stairs, " + 
					"Press 2 to return to room 2, " + 
					"Press 3 to return to room 3";
		if (Input.GetKeyDown(KeyCode.S))						{mystate = States.stairs;} 
		else if (Input.GetKeyDown(KeyCode.Alpha2))				{mystate = States.room_2;}
		else if (Input.GetKeyDown(KeyCode.Alpha3))				{mystate = States.room_3;}
	}
	
	void state_storage(){
		text.text = "st" +
					"\n\n" +
					"Press K to take Key, " + 
					"Press B to return to alleyway";
		if (Input.GetKeyDown(KeyCode.K))						{} 
		else if (Input.GetKeyDown(KeyCode.B))					{mystate = States.alleyway;}
	}
	
	void state_room_4(){
		text.text = "r2" +
			"\n\n" +
				"Press C to go to corridor, " + 
				"Press B to return to alleyway";
		if (Input.GetKeyDown(KeyCode.C))						{mystate = States.corridor;} 
		else if (Input.GetKeyDown(KeyCode.B))					{mystate = States.alleyway;}
	}
	
	void state_room_3(){
		text.text = "Game Over" +
					"\n\n" +
					"Press Enter to restart the game";
		if (Input.GetKeyDown(KeyCode.Return))						{mystate = States.room_1;} 
	}
	void state_room_2(){
		text.text = "r2" +
					"\n\n" +
					"Press S to go to storage room, Press C to go to corridor, " + 
					"Press B to return to alleyway";
		if (Input.GetKeyDown(KeyCode.S))						{mystate = States.storage;} 
		else if (Input.GetKeyDown(KeyCode.C))					{mystate = States.corridor;} 
		else if (Input.GetKeyDown(KeyCode.B))					{mystate = States.alleyway;}
	}
	
	void state_piece_of_paper(){
		text.text = "pop" +
					"\n\n" +
					"Press B to put it back";
		if (Input.GetKeyDown(KeyCode.B))						{mystate = States.alleyway;} 
	}
	
	void state_alleyway(){
		text.text = "a" +
			"\n\n" +
				"Press R to read the piece of paper in the floor, Press 2 to go to room 2, " + 
				"Press 3 to go to room 3, Press 4 to go to room 4";
		if (Input.GetKeyDown(KeyCode.R))						{mystate = States.piece_of_paper;} 
		else if (Input.GetKeyDown(KeyCode.Alpha2))				{mystate = States.room_2;} 
		else if (Input.GetKeyDown(KeyCode.Alpha3))				{mystate = States.room_3;} 
		else if (Input.GetKeyDown(KeyCode.Alpha4))				{mystate = States.room_4;} 
	}
	
	void state_window(){
		text.text = "w" +
			"\n\n" +
				"Press C to close the window ";
		if (Input.GetKeyDown(KeyCode.C)){
			mystate = States.room_1;
		}
	}
	
	void state_room_1(){
		text.text = "r1" +
					"\n\n" +
					"Press A to open the door and go to alleyway or Press W to open window";
		if (Input.GetKeyDown(KeyCode.A)){
			mystate = States.alleyway;
		} else if (Input.GetKeyDown(KeyCode.W)){
			mystate = States.window;
		} 
	}
	
}
