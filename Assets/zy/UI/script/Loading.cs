using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (loadScene ());
	}

	IEnumerator loadScene()
	{
		AsyncOperation async = Application.LoadLevelAsync (2);
		yield return async;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
