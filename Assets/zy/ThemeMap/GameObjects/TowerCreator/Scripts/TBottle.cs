using UnityEngine;
using System.Collections;

public class TBottle : MonoBehaviour {

	public GameObject bottle;
	public GameObject cloud;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//touch event
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//从摄像机发出到点击坐标的射线
			RaycastHit hitInfo;
			if(Physics.Raycast(ray,out hitInfo)) {
				
				GameObject gameObj = hitInfo.collider.gameObject;
				if(gameObj == this.gameObject) {

					Animator cloudAnimator = cloud.GetComponent<Animator>();
					cloudAnimator.Play("Cloud");

					AudioSource aud = cloud.GetComponent<AudioSource>();
					aud.Play();

					GameObject towerCreator = GameObject.Find("TowerCreator");
					GameObject bottle01 = GameObject.Instantiate (bottle) as GameObject;
					bottle01.transform.position = towerCreator.transform.position;
					towerCreator.SendMessage("ChangeState", TowerCreator.States.Delete2);

				}
			}
		}
	}
}