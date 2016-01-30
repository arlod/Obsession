using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {
	public GameObject player;
	public float objectViewDistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseOver(){

		player.GetComponent<ZoomEffect> ().target.x = gameObject.transform.position.x;
		player.GetComponent<ZoomEffect> ().target.z = gameObject.transform.position.z;
		player.GetComponent<ZoomEffect> ().targetdistance = objectViewDistance;
		player.GetComponent<ZoomEffect> ().CanZoom = true;

		Behaviour halo = (Behaviour)GetComponent("Halo");

		halo.enabled = true; // false

	}
	void OnMouseExit(){
		Behaviour halo = (Behaviour)GetComponent("Halo");

		halo.enabled = false; // false

		player.GetComponent<ZoomEffect> ().CanZoom = false;

	}

}
