using UnityEngine;
using System.Collections;

public class BulletMng : MonoBehaviour {

	public GameObject smallBullet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//callback Function
	void CreateBullet(){

		GameObject bullet = GameObject.Instantiate(smallBullet) as GameObject;
		bullet.transform.position = smallBullet.transform.position;
		bullet.transform.rotation = smallBullet.transform.rotation;
		bullet.SetActive(true);

		AudioSource aud = this.GetComponent<AudioSource> ();
		aud.Play ();
	}
}
