using UnityEngine;
using System.Collections.Generic;

public class StoryController : MonoBehaviour {
	public int dayCount;
	public GameObject[] Day1;
	public GameObject[] Day20;
	public GameObject[] Day73;

	public GameObject titleCard;
//	public Transform titleText;

	public TextMesh titleText;

	public bool titleFade;

	private int currentDay;


	public List <GameObject[]> days = new List<GameObject[]>();

	// Use this for initialization
	void Start () {
		init ();
	}

	public void init(){
		days.Add (Day1);
		days.Add (Day20);
		days.Add (Day73);
//		titleText = transform.GetComponent<TextMesh>();
		displayTitleCard ();
		currentDay = -1;
		titleFade = false;
	}

	public void nextTitleCard(){
		displayTitleCard ();
		currentDay++;
		titleText.text = "Day " + currentDay;
		if (currentDay != 0) {
			foreach(GameObject obj in days[currentDay-1]){
				obj.SetActive(false);
			}
		}
		foreach(GameObject obj in days[currentDay]){
			obj.SetActive(true);
		}
	}

	public void displayTitleCard(){
		titleCard.SetActive (true);
		titleText.font.material.color = Color.white;
		Invoke ("hideTitleCard", 2f);

	}

	public void hideTitleCard(){
		titleCard.SetActive (false);
		titleFade = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (titleFade) {
			if(titleText.font.material.color.a < Time.deltaTime){
				titleText.font.material.color = new Color(0f,0f,0f, 0f);
				titleFade = false;
			} else {
				Color tmp = new Color(1f,1f,1f,1f);
				tmp.a = titleText.font.material.color.a - Time.deltaTime;
				titleText.font.material.color = tmp;
			}

		}


		if (Input.GetMouseButtonDown (1)){
			if(currentDay < dayCount){
				nextTitleCard();
			}
		}



	}
}
