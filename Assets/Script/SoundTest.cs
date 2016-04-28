using UnityEngine;
using System.Collections;

public class SoundTest : MonoBehaviour {

	public AudioClip bgm1;
	public AudioClip bgm2;
	public AudioSource aud;
	private int count = 1;

	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();
	}

	public void increaseCount (){
		count = count + 1;
		if (count > 2) {
			count = 1;
		}
	}
	public void bgmPlay(){
		if (count == 1) {
			aud.clip = bgm1;
			aud.Play ();
		} else if (count == 2) {
			aud.clip = bgm2;
			aud.Play ();
		}
	}

}
