using UnityEngine;
using System.Collections;

public class BlindTilt : MonoBehaviour {

	public int degreesOfRotation;

	// Use this for initialization
	void Start () {
//		GameObject[] blinds = gameObject.getC<GameObject>();
//		foreach (GameObject blind in blinds) {
//			blind.transform.eulerAngles =  new Vector3(0, degreesOfRotation, 0);
//		}
	}
	
	// Update is called once per frame
	void Update () {
//		GameObject[] blinds = gameObject.GetComponentsInChildren<GameObject>();
//		foreach (GameObject blind in blinds) {
//			blind.transform.eulerAngles =  new Vector3(0, degreesOfRotation, 0);
//		}
		foreach (Transform child in transform)
		{
			child.transform.eulerAngles =  new Vector3(0, degreesOfRotation, 0);
			//child is your child transform
		}
	}
}
