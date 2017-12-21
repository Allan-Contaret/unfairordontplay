using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MonoBehaviour {

	private Text FinalText;
	public AudioClip playSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		
		source = GetComponent<AudioSource>();
		FinalText = GameObject.Find ("VictoryText").GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider){

		source.PlayOneShot(playSound);
		FinalText.text = "Victoire!";
	


	}
}
