using UnityEngine;
using System.Collections;

public class FXTest : MonoBehaviour {

	public AudioClip FX1;
	public AudioClip FX2;
	public AudioClip FX3;
	public AudioClip FX4;
	public AudioClip FX5;
	public AudioClip FX6;

	public AudioSource aud;
	private int count = 1;

	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();
	}

	public void increaseCount (){
		count = count + 1;
		if (count > 6) {
			count = 1;
		}
	}
	public void fxPlay(){
		if (count == 1) {
			aud.clip = FX1;
			aud.Play ();
		} else if (count == 2) {
			aud.clip = FX2;
			aud.Play ();
		} else if (count == 3) {
			aud.clip = FX3;
			aud.Play ();
		} else if (count == 4) {
			aud.clip = FX4;
			aud.Play ();
		} else if (count == 5) {
			aud.clip = FX5;
			aud.Play ();
		} else if (count == 6) {
			aud.clip = FX6;
			aud.Play ();
		}
	}

}
