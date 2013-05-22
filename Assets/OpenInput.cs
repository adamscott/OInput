using UnityEngine;
using System.Collections;

static public class OpenInput {
	
	const string INPUT_SETUP = "dynamicInput_initSetup";
	
	static bool initialized = false;
	
	static void Initialize() {
		if (!initialized) {
			Debug.Log("Has key?" + PlayerPrefs.HasKey(INPUT_SETUP));
			if (PlayerPrefs.HasKey(INPUT_SETUP)) {
				
			}
			
			initialized = true;
		}
	}
	
	static public float GetAxis(string axisName) {
		Initialize();
		
		return 0.0f;
	}
	
}
