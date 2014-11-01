//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class BottleDefense : DefenseProuduct {

	public int bottleLevel;
	public GameObject smallBulletPrefab;
	private GameObject bullet;
	private SmallBullet[] bulletArray;

	public enum StatesOfDefense{
		IDLE = 0,
		ATTACK = 1,
		LEVELUP = 2
	};

	private FiniteStateMachine<BottleDefense,BottleDefense.StatesOfDefense> fsm;
			
	public float currentAngle;

	public IdleStateOfBottleDefense stateIdle = new IdleStateOfBottleDefense();
	public AttackStateOfBottleDefense stateAttack = new AttackStateOfBottleDefense();
	public LevelupStateOfBottleDefense stateLevelup = new LevelupStateOfBottleDefense();

	// Use this for initialization
	void Start () {
		fsm = new FiniteStateMachine<BottleDefense, BottleDefense.StatesOfDefense>(this);

		fsm.RegisterState(stateIdle);
		fsm.RegisterState(stateAttack);
		fsm.RegisterState(stateLevelup);

		bottleLevel = 1;
	}

	void createBullet(){
		Debug.Log("***************fire****************");
		if(!bullet)
		{
			bullet = (GameObject)Instantiate(smallBulletPrefab);
			float angleDelta = (gameObject.transform.eulerAngles.z * Mathf.PI/180.0f);
			bullet.SendMessage("setAngle",angleDelta);
			//bullet.SendMessage("setAngle",gameObject.transform.rotation.z);
		}

	}

	void LevelUp(){
		Debug.Log ("**********Levelup***********");

		if(bottleLevel < 3){
			bottleLevel++;
		}

		switch(bottleLevel){
		case 1:
			//none
			break;
		case 2:
			//Animator anim = gameObject.get
			break;
		case 3:
			break;
		default:
			break;
		}

		fsm.RevertToPreviousState();
	}

	// Update is called once per frame
	void Update () {
		fsm.Update();
	}

	void changeState(BottleDefense.StatesOfDefense newState)
	{
		fsm.ChangeState(newState);
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

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("BottleDefense-in-collision");
		if(col.gameObject.tag == "BulletTag"){
			//bulletArray[] = col.gameObject;
			Debug.Log ("===========bullet in !!!========");
		}
	}

}
