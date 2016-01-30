using UnityEngine;
using System.Collections.Generic;

public class StoryController : MonoBehaviour {
//	public GameDay[] days;

	public GameObject titleCard;
	public string title;
	public TextMesh titleText;

	private bool titleFade;

	private int currentDay;

	// Use this for initialization
	void Start () {
		init ();
	}

	public void init(){
		currentDay = 0;
		titleFade = false;
		titleText.text = title;
		displayTitleCard ();
	}

//	public void nextTitleCard(){
//		currentDay++;
//		titleText.text = days[currentDay-1].dayName;
//		displayTitleCard ();
//		if (currentDay != 1) {
//			foreach(GameItem obj in days[currentDay-2].items){
//				obj.item.SetActive(false);
//			}
//		}
//		foreach(GameItem obj in days[currentDay-1].items){
//			obj.item.SetActive(true);
//		}
//	}

//	public void playCurrentAudioClip(){
//		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
//		audioSource.clip = days [currentDay - 1].items [0].audio;
//		audioSource.Play();
//	}

	public void displayTitleCard(){
		titleCard.SetActive (true);
		titleText.font.material.color = Color.white;
		Invoke ("hideTitleCard", 2f);
	}

	public void hideTitleCard(){
		
		titleFade = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (titleFade) {
			if(titleText.font.material.color.a < Time.deltaTime){
				titleText.font.material.color = new Color(0f,0f,0f, 0f);
				titleFade = false;
				titleCard.SetActive (false);
			} else {
				Color tmp = new Color(1f,1f,1f,1f);
				tmp.a = titleText.font.material.color.a - Time.deltaTime;
				titleText.font.material.color = tmp;
//				titleCard.GetComponent<Renderer>().material.color.a = tmp.a;
			}


		}


//		if (Input.GetMouseButtonDown (1)){
//			if(currentDay < days.Length){
//				nextTitleCard();
//			}
//		}



	}
//
//	[System.Serializable]
//	public class GameDay{
//		public GameItem[] items;
//		public string dayName;
//	}
//		
//	[System.Serializable]
//	public class GameItem{
//		public GameObject item;
//		public AudioClip audio;
//		public bool hasInteraction;
//
//		public GameObject getItem(){
//			return item;
//		}
//
//		public AudioClip getAudio(){
//			return audio;
//		}
//	}
}
