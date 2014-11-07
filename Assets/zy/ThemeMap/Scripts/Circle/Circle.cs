using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartCircleAnimation(){
		Animator animator = this.GetComponent<Animator> ();
		animator.Play("Circle");
	}

	void SetUnActive(){
		this.gameObject.SetActive (false);
	}
}
