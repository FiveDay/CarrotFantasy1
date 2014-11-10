//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class BottleDefense : DefenseProuduct {

	public int bottleLevel;
	public GameObject smallBulletPrefab;
	private GameObject bullet;
	private SmallBullet[] bulletArray;

	public Vector3 vecOld;

	public ArrayList enemyArray;

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

		//1:if in the range had an enemy,set attackstatus
		//2:if no enemy,set idlestatus.
		this.changeState(BottleDefense.StatesOfDefense.IDLE);

		enemyArray = new ArrayList(0);
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

	void findFirstTargetAndChangeAngle()
	{
		Debug.Log("111111111111111111111111111111");
		if(enemyArray.Count>0){
			Debug.Log("*&&^%^*(OJHGFRTU)OPOJHYUOOPKJMM");
			GameObject enemyFirst = enemyArray[0] as GameObject;

			Vector3 targetVector = this.gameObject.transform.position - enemyFirst.transform.position;
			var forward = gameObject.transform.forward;
			var angle = Vector3.Angle(targetVector, forward);

			SpriteRenderer myspriteRender = this.gameObject.GetComponent<SpriteRenderer>();
			myspriteRender.transform.Rotate(0,0,180-angle * 180.0f/Mathf.PI);

			Debug.Log(targetVector.z);

		}

	}

//	void traceEnemy()
//	{
//	}

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
		Debug.Log("BottleDefense-in-collision,filename:BottleDefense.cs,OnTriggerEnter2D");
		if(col.gameObject.tag == "BulletTag"){
			//bulletArray[] = col.gameObject;
			Debug.Log ("===========bullet in !!!========,filename:BottleDefense.cs,OnTriggerEnter2D");
		}else if(col.gameObject.tag == "EnemyTag"){
			Debug.Log("********* an enemy in bottleRange ^^^^^^^^^^^^^^^^,filename:BottleDefense.cs,OnTriggerEnter2D");
			enemyArray.Add(col.gameObject);

			this.changeState(BottleDefense.StatesOfDefense.ATTACK);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		Debug.Log("BottleDefense-out-collision,filename:BottleDefense.cs,OnTriggerExit2D");
		if (col.gameObject.tag == "EnemyTag"){
			enemyArray.Remove(col.gameObject);
		}
	}


//	//1:当进入碰撞器
//	void OnCollisionEnter( Collision collisionInfo ) {
//		Debug.Log("BottleDefense-in-collision");
//		if(collisionInfo.gameObject.tag == "BulletTag"){
//			//bulletArray[] = col.gameObject;
//			Debug.Log ("===========bullet in !!!========");
//		}else if(collisionInfo.gameObject.tag == "EnemyTag"){
//			Debug.Log("********* an enemy in bottleRange ^^^^^^^^^^^^^^^^");
//			//int allEnemyCount = enemyArray.Length;
//			//enemyArray[allEnemyCount++] = col.gameObject ;
//		}
//	}
//	
//	//2:当退出碰撞器
//	void OnCollisionExit( Collision collisionInfo ) {
//		
//	}


}
