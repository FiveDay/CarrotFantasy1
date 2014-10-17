using UnityEngine;
using System.Collections;

public class SettingButton : MonoBehaviour {

	public GameObject camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick () {  
		Animator ani = camera.GetComponent<Animator> ();
		ani.Play ("cameraUp");
	}  
}
