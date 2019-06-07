using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeetTails : MonoBehaviour {
	public GameObject tails_model;
	bool can_be_meet = true;
	AudioSource audioSrc;
	public AudioClip idle_ring_audio;
	public AudioClip touched_ring_audio;
	bool meet_tails;
	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<SonicController> () && can_be_meet) {
			//can_be_meet = false;
			//Debug.Log("Meet tails");
			yield return new WaitForSeconds (.6f);
		}
        //tails_model.AddComponent("TailsController");
	}
}
