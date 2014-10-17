using UnityEngine;
using System.Collections;

public class DataBtn : MonoBehaviour {

	public GameObject optionBg;
	public GameObject dataBg;
	public GameObject productorBg;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		productorBg.SetActive (false);
		optionBg.SetActive (false);
		dataBg.SetActive (true);
	}
}
