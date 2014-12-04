using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	public GameObject camera;

	public GameObject mainMenu;
	public GameObject stage;
	public GameObject level;
	public GameObject helping;
	public GameObject setting;

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

	//action function
	public void SelectLevel(GameObject item)
	{
		Application.LoadLevel(1) ;
	}
	public void SelectStage(GameObject item)
	{
		level.transform.position = new Vector3(0, 0, 0);
		level.SetActive (true);
		stage.SetActive (false);
	}
	public void StageHelp()
	{
		Animator ani = camera.GetComponent<Animator> ();
		ani.enabled = false;
		camera.transform.position = camera.transform.position + new Vector3 (helping.transform.position.x, helping.transform.position.y, 0);
		stage.SetActive (false);
		mainMenu.SetActive (true);
	}
	public void StageBack()
	{
		stage.SetActive (false);
		mainMenu.SetActive (true);
	}
	public void Type1OnClick()
	{
		stage.transform.position = new Vector3(0, 0, 0);
		stage.SetActive (true);
		mainMenu.SetActive (false);
	
	}
	public void SettingBtnOnClick(){
		Animator ani = camera.GetComponent<Animator> ();
		ani.enabled = true;
		ani.Play ("cameraUp");
	}

	public void HelpingBtnOnClick () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.enabled = true;
		ani.Play ("cameraDown");
	}

	public void HomeBtnOnClick () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.enabled = true;
		ani.Play ("cameraUpToDown");
	}
	public void HomeBtnOnClick2 () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.enabled = true;
		ani.Play ("cameraDownToUp");
	}

	public void MusicSwitchOnClick() {
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

	public void BackgroundMusicSwitchOnClick(){
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

	public void OptionBtnOnClick()
	{
		productorBg.SetActive (false);
		optionBg.SetActive (true);
		dataBg.SetActive (false);
	}

	public void DataBtnOnClick()
	{
		productorBg.SetActive (false);
		optionBg.SetActive (false);
		dataBg.SetActive (true);
	}
	
	public void ProductorBtnOnClick()
	{
		productorBg.SetActive (true);
		optionBg.SetActive (false);
		dataBg.SetActive (false);
	}
}
