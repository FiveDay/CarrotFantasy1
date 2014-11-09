using UnityEngine;
using System.Collections;

public class MainScene : MonoBehaviour {

	public GameObject camera;

	public GameObject musicSwitch;
	public GameObject backgroundMusicSwitch;

	public GameObject optionBg;
	public GameObject dataBg;
	public GameObject productorBg;

	protected bool musicSwitchFlag = true; 
	protected bool backgroundMusicSwitchFlag = true; 

	// Use this for initialization
	void Start () {
		//GameObject obj = GameObject.Find("signal-2");
		//obj.SendMessage ("SetState", UIButtonColor.State.Normal, SendMessageOptions.RequireReceiver); 
		//obj.SendMessage ("SetState", UIButtonColor.State
		//                .Normal, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SettingBtnOnClick(GameObject gameObject){
		Animator ani = camera.GetComponent<Animator> ();
		ani.Play ("cameraUp");
	}

	void HelpingBtnOnClick () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.Play ("cameraDown");
	}

	void HomeBtnOnClick () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.Play ("cameraUpToDown");
	}
	void HomeBtnOnClick2 () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.Play ("cameraDownToUp");
	}

	void MusicSwitchOnClick() {
		if (this.musicSwitchFlag) {  
			musicSwitch.GetComponent<UISprite> ().spriteName = "setting02-voice-1";  
			musicSwitch.GetComponent<UIButton> ().normalSprite = "setting02-voice-1";  
			this.musicSwitchFlag = false;  
		}  
		else{  
			musicSwitch.GetComponent<UISprite>().spriteName = "setting02-voice-2";  
			musicSwitch.GetComponent<UIButton>().normalSprite = "setting02-voice-2";  
			this.musicSwitchFlag = true;  
		}
	}

	void BackgroundMusicSwitchOnClick(){
		if (this.backgroundMusicSwitchFlag) {  
			backgroundMusicSwitch.GetComponent<UISprite> ().spriteName = "setting02-music-1";  
			backgroundMusicSwitch.GetComponent<UIButton> ().normalSprite = "setting02-music-1";  
			this.backgroundMusicSwitchFlag = false;  
		}  
		else{  
			backgroundMusicSwitch.GetComponent<UISprite>().spriteName = "setting02-music-2";  
			backgroundMusicSwitch.GetComponent<UIButton>().normalSprite = "setting02-music-2";  
			this.backgroundMusicSwitchFlag = true;  
		}
	}

	void DataBtnOnClick()
	{
		productorBg.SetActive (false);
		optionBg.SetActive (false);
		dataBg.SetActive (true);
	}

	void OptionBtnOnClick()
	{
		productorBg.SetActive (false);
		optionBg.SetActive (true);
		dataBg.SetActive (false);
	}

	void ProductorBtnOnClick()
	{
		productorBg.SetActive (true);
		optionBg.SetActive (false);
		dataBg.SetActive (false);
	}
}
