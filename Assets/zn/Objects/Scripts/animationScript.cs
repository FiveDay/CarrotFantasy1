//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class animationScript : MonoBehaviour {

	 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	//推迟更新，在Update()方法执行完后调用，同样每一帧都调用
	void LateUpdate () {

	}

	//脚本唤醒，在脚本生命周期中只执行一次
	void Awake () {

	}

	//固定更新。Edit->project settings ->time可以修改更新频率
	void FixedUpdate () {

	}

	void OnDestroy () {

	}

	void OnGUI () {

	}

	//for fire
	void fire() {
//		Debug.Log("***************fire****************");
//		GameObject bullet = (GameObject)Instantiate(smallBulletPrefab);
//		BottleDefense bottle = (BottleDefense)gameObject;
//		bullet.SendMessage("setAngle",);
	}
}
