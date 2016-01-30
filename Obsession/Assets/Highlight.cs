using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseOver(){
		Behaviour halo = (Behaviour)GetComponent("Halo");
		
		halo.enabled = true; // false

	}
	void OnMouseExit(){
		Behaviour halo = (Behaviour)GetComponent("Halo");
		
		halo.enabled = false; // false

	}

}
