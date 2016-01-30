using UnityEngine;
using System.Collections;

public class WorldControl : MonoBehaviour {
	bool LockCursor = true;

	// Use this for initialization
	void Start () {

			//Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (LockCursor){

		}

	}
	void UpdateLock(){
		Cursor.lockState = CursorLockMode.Locked;

	}
}
