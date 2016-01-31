﻿using UnityEngine;
using System.Collections;

public class ZoomEffect : MonoBehaviour {
	public Vector3 target;
	public Vector3 startPos = new Vector3(1, 1.03f, 1);
	public float targetdistance = 0;
	public bool CanZoom = false;
	private bool CanZoom4REEL = false;
	private float startTime;
	public float pauseTime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (CanZoom && Input.GetMouseButtonDown (0)) {
			CanZoom4REEL = true;
		
		}
		if (CanZoom4REEL && (Mathf.Abs(gameObject.transform.position.x - target.x) > targetdistance || Mathf.Abs(gameObject.transform.position.z - target.z) > targetdistance)) {
			startTime = Time.time;
			target.y = 1f;
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position, target, 0.1f);
		} else if(!Input.GetMouseButton (0) && Time.time - startTime > pauseTime){
			CanZoom4REEL = false;

			if(Mathf.Abs(gameObject.transform.position.x - startPos.x) > 0.01f|| Mathf.Abs (gameObject.transform.position.z - startPos.z) > 0.01)
				target.y = 1f;
				gameObject.transform.position = Vector3.Lerp (gameObject.transform.position, startPos, 0.1f);
			//Debug.Log(gameObject.transform.position.y);
		}
		Vector3 temp = transform.position; // copy to an auxiliary variable...
		temp.y = 1; // modify the component you want in the variable...
		transform.position = temp; // and save the modified value
	}
}