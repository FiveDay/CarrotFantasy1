using UnityEngine;
using System.Collections;

public class ThemeMapManager : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Trigger callback function
	void OnTriggerEnter2D(Collider2D col)
	{

	}
	
	void OnTriggerExit2D(Collider2D col)
	{
		Destroy(col.gameObject);
	}
}
