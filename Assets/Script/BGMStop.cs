using UnityEngine;
using System.Collections;

public class BGMStop : MonoBehaviour {
	SoundTest soundtest;
	public AudioSource audio;

	void Start(){
		audio = soundtest.aud;
	}

	public void StopAudio(){
		audio.Stop ();
	}

}
