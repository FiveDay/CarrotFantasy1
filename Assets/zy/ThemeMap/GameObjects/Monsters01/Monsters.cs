using UnityEngine;
using System.Collections;

public class Monsters : MonoBehaviour {

	public Blood blood;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (blood.getBloodValue() == 0){
			Destroy(this.gameObject);
			return;
		}

	}

	//Trigger callback function
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Carrot") {
			Destroy (this.gameObject);
			return;
		}
		if(col.tag == "BulletTag")
			blood.LoseBlood ();
	}
}
