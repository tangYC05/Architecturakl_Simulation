using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_CurtainRotation : MonoBehaviour {

	//This script rotates the curtains
	//upon players trigger

	Cloth cloth;
	public GameObject curtainGroup;
	Component[] curtains;
	public float rotationgAngle = 10;

	//Get all the curtains and put them in array
	void Start()
	{
		curtains = curtainGroup.GetComponentsInChildren<Cloth> ();
	}

	//When player stay inside the trigger box
	void OnTriggerStay (Collider col)
	{
		//For every object in the array, rotate them
		foreach (Cloth cloth in curtains) 
		{
			cloth.transform.Rotate (Vector3.up, rotationgAngle, Space.Self);
		}
	}

}
