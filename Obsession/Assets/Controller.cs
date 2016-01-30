using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public Vector2 targetPosition;
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			targetPosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
		}
		
		transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
	}
}

