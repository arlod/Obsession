using UnityEngine;
using System.Collections;

public class BlindTilt : MonoBehaviour {

	public int degreesOfRotation;

	// Use this for initialization
	void Start () {
				foreach (Transform child in transform)
		{
			child.transform.eulerAngles =  new Vector3(degreesOfRotation, 0, 0);
			//child is your child transform
		}
	}
	
	// Update is called once per frame
	void Update () {
//		
	}
}
