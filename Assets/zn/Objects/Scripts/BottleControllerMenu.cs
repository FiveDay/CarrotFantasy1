//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class BottleControllerMenu : MonoBehaviour {

	public Texture2D buttonTexture;
	public string str;
	public int frameTime;

	//public Transform bottle;



	private Animator anim;

	// Use this for initialization
	void Start () {
		str = "select a button";

	}
	
	// Update is called once per frame
	void Update () {
		//up
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Debug.Log("upKeyDown");
		}
		//down
		if (Input.GetKey(KeyCode.DownArrow))
		{
			Debug.Log("downKeyDown");
		}
		//left
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Debug.Log("leftKeyDown");

			SpriteRenderer myspriteRender = gameObject.GetComponent<SpriteRenderer>();
			Debug.Log(myspriteRender.sprite);
			myspriteRender.transform.Rotate(0,0,30*Time.deltaTime);
		}
		//right
		if(Input.GetKey(KeyCode.RightArrow))
		{
			Debug.Log("rightKeyDown");

			SpriteRenderer myspriteRender = gameObject.GetComponent<SpriteRenderer>();
			Debug.Log(myspriteRender.sprite);
			myspriteRender.transform.Rotate(0,0,-30*Time.deltaTime);

		}

	}

	//推迟更新，在Update()方法执行完后调用，同样每一帧都调用
	void LateUpdate () {

	}

	//脚本唤醒，在脚本生命周期中只执行一次
	void Awake () {
		anim = gameObject.GetComponent<Animator> ();
	}


	//固定更新。Edit->project settings ->time可以修改更新频率
	void FixedUpdate () {

	}

	void OnDestroy () {

	}

	void OnGUI () {
		GameObject obj = gameObject.transform.GetChild(1).gameObject;
		Animator anim2 = obj.GetComponent<Animator>();

		GameObject bottleDefense = GameObject.Find("WeaponBottle") ;

		if (GUI.Button (new Rect (20, 20, 50, 20), "idle")) {
			Debug.Log("idle........");

			if(bottleDefense)
			{
				bottleDefense.SendMessage("changeState",BottleDefense.StatesOfDefense.IDLE);
			}


		}

		if (GUI.Button (new Rect (20, 50, 50, 20), "attack")) {
			Debug.Log("attack.....");

			if(bottleDefense)
			{
				bottleDefense.SendMessage("changeState",BottleDefense.StatesOfDefense.ATTACK);
			}

		}
		if (GUI.Button (new Rect (20, 80, 50, 20), "levelup")) {
			Debug.Log("level up.....");

			if(bottleDefense)
			{
				bottleDefense.SendMessage("changeState",BottleDefense.StatesOfDefense.LEVELUP);
			}
		}
	}
}
