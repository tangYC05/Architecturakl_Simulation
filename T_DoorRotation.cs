using UnityEngine;
using System.Collections;

//This script is used to rotate the door

public class T_DoorRotation : MonoBehaviour {

	//This script rotates the door
	//when player touch the trigger

	public int openAngle = 80;
	public GameObject targetDoor;
	public bool isOpen = false;

	//When player enter the trigger
	void OnTriggerEnter(Collider col)
	{
		//Rotate the door with the angle given
		RotateDoor (openAngle);
	}

	//When player step out of the trigger
	void OnTriggerExit(Collider col)
	{
		//Rotate the door back to the angle given
		RotateDoor (-openAngle);
	}

	//Rotate the door on the local pivot
	public void RotateDoor(int openAngle)
	{
		targetDoor.transform.Rotate (Vector3.up, openAngle, Space.Self); 
	}

}
