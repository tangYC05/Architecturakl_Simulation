using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script triggers the light

public class T_LightTrigger : MonoBehaviour {

	public GameObject roomLightsGroup;
	bool isLightOn = false;

	//Turn the light off first
	void Start()
	{
		roomLightsGroup.SetActive(false);
	}

	//When player step into the trigger
	void OnTriggerEnter(Collider col)
	{
		//If the light is off
		if (isLightOn == false) 
		{
			//Turn on the lights
			roomLightsGroup.SetActive (true);
			isLightOn = true;
		} 
			
		//If the light is on
		else if (isLightOn == true) 
		{
			//Turn off the light
			roomLightsGroup.SetActive(false);
			isLightOn = false;
		}
	}

}
