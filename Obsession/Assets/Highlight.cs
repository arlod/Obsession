using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {
	private GameObject player;
	public float objectViewDistance;
	public float pauseTime = 5;
	private bool HasClickedOnce = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			if (!HasClickedOnce) {
				player.GetComponent<ZoomEffect> ().pauseTime = pauseTime;
				HasClickedOnce = true;
			} else {
				player.GetComponent<ZoomEffect> ().pauseTime = 0;
			}
		}

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
