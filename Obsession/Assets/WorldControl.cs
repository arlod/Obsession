using UnityEngine;
using System.Collections;

public class WorldControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
			//Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.lockState = CursorLockMode.Locked;

	}
}
