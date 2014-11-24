using UnityEngine;
using System.Collections;

public class ReadyGo : MonoBehaviour {

	public AudioClip countDownClip;
	public AudioClip goClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//interface function
	public void PlayCountDownMusic(){
		AudioSource audioSource = this.GetComponent<AudioSource> ();
		audio.clip = countDownClip;
		audio.Play ();
	}

	public void PlayGoMusic(){
		AudioSource audioSource = this.GetComponent<AudioSource> ();
		audio.clip = goClip;
		audio.Play ();
	}

	public void SetUnActiveOfReadyGo(){
		this.gameObject.SetActive(false);
	}
}
