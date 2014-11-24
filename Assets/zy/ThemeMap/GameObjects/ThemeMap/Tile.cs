using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		this.gameObject.renderer.sharedMaterial.color = new Color (0.0F, 1.0F, 0.0F, 0.0F);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//从摄像机发出到点击坐标的射线
			RaycastHit hitInfo;
			if(Physics.Raycast(ray,out hitInfo)) {

				GameObject gameObj = hitInfo.collider.gameObject;
				if(gameObj == this.gameObject) {

					GameObject obj = GameObject.Find("TowerCreator");
					if(obj != null
					   && obj.transform.position != this.gameObject.transform.position) {
						obj.transform.position = this.gameObject.transform.position;
						obj.SendMessage("ChangeState", TowerCreator.States.Add);
					}else if(obj != null
					         && obj.transform.position == this.gameObject.transform.position) {
						obj.SendMessage("ChangeState", TowerCreator.States.Delete);
					}else {
						Debug.Log("Error:TowerCreator == null");
					}
				}
			}
		}
	}

	void OnMouseDown() {
		 
		//_ObjectOftowerCreator = _towerCreator.getGameObjectByName("abc");
		//_ObjectOftowerCreator.transform.parent = this.gameObject.transform;
	}
}
