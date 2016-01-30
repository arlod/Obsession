using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Highlight : MonoBehaviour {
	private GameObject player;

	public bool isBed;
	public string levelToLoadNext;

	public float objectViewDistance;
	public float pauseTime = 5;
	private bool HasClickedOnce = false;

	public AudioClip narrationClip;
	private AudioSource narrationSource;

	private bool onMouseOver = false;
	private Camera cam;

	public string mouseOverIdentifier;

	public int hTextShift;
	public int vTextShift;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		narrationSource = gameObject.AddComponent<AudioSource> ();
		narrationSource.clip = narrationClip;
		cam = Camera.main; 
//		Canvas canv = gameObject.AddComponent<Canvas>();
//		Text tx = canv.ch
//		tx.text = mouseOverIdentifier;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI() {

		if (onMouseOver) {
			Vector3 screenPos = cam.WorldToScreenPoint(gameObject.transform.position);
			//Debug.Log (Screen.width - (int)screenPos.y + vTextShift);
			GUI.Label(new Rect (screenPos.x + hTextShift, Screen.width - (int)screenPos.y + vTextShift, 100, 100),mouseOverIdentifier);
//			GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.5f); //0.5 is half opacity 
//				
//					
//			Vector3 screenPos = cam.WorldToScreenPoint(gameObject.transform.position);
//			GUI. (new Rect (screenPos.x, screenPos.y + 50, 100, 100), "This is a title");
		}
	}

	void OnMouseOver(){
		onMouseOver = true;

		if (Input.GetMouseButtonDown (0)) {
			if (isBed) {
				Application.LoadLevel (levelToLoadNext);
			} else {
				if (!HasClickedOnce) {
					player.GetComponent<ZoomEffect> ().pauseTime = pauseTime;
					HasClickedOnce = true;

					narrationSource.Play ();
				} else {
					player.GetComponent<ZoomEffect> ().pauseTime = 0;
				}
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

		onMouseOver = false;

	}


}
