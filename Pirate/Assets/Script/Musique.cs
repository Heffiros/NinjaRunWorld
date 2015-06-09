using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Musique : MonoBehaviour {
	// Use this for initialization
	 void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
