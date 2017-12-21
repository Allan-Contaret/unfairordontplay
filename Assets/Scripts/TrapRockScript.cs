using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRockScript : MonoBehaviour {

	private bool CanTake = false;
	public GameObject Player;
	public AudioClip playSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightShift) && CanTake)
		{
			source.PlayOneShot(playSound);
			Destroy (Player);
		}
		
	}
	void OnTriggerEnter(Collider collider)
	{

		if (collider.gameObject.tag == "Player")
		{
			CanTake = true;
		}
	}
}
