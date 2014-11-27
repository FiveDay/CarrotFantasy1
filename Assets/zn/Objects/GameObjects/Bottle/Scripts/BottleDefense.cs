//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class BottleDefense : MonoBehaviour {

	public GameObject weaponBottle;

	public int bottleLevel;

	public Vector3 vecOld;

	public float currentAngle;
	
	public enum StatesOfDefense{
		IDLE,
		ATTACK,
		LEVELUP,
	};

	public ArrayList enemyArray;

	private FiniteStateMachine<BottleDefense,BottleDefense.StatesOfDefense> fsm;

	private IdleStateOfBottleDefense stateIdle = new IdleStateOfBottleDefense();
	private AttackStateOfBottleDefense stateAttack = new AttackStateOfBottleDefense();
	private LevelupStateOfBottleDefense stateLevelup = new LevelupStateOfBottleDefense();

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

	// Use this for initialization
	void Start () {
		fsm = new FiniteStateMachine<BottleDefense, BottleDefense.StatesOfDefense>(this);
		bottleLevel = 1;
		enemyArray = new ArrayList(0);

		fsm.RegisterState(stateIdle);
		fsm.RegisterState(stateAttack);
		fsm.RegisterState(stateLevelup);

		//1:if in the range had an enemy,set attackstatus
		//2:if no enemy,set idlestatus.
		fsm.ChangeState(stateIdle);
	}

	// Update is called once per frame
	void Update () {
		fsm.Update();
	}

	//Interface function
	public void ChangeState(BottleDefense.StatesOfDefense newState)
	{
		fsm.ChangeState(newState);
	}

	//Trigger callback function
	void OnTriggerEnter2D(Collider2D col)
	{
		 if(col.gameObject.tag == "EnemyTag"){
			Debug.Log("==========add enemyTag=============================");
			enemyArray.Add(col.gameObject);
			this.ChangeState(BottleDefense.StatesOfDefense.ATTACK);
		}
	}
	
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "EnemyTag"){
			Debug.Log("==========remove enemyTag=============================");
			enemyArray.Remove(col.gameObject);
			this.ChangeState(BottleDefense.StatesOfDefense.IDLE);
		}
	}

}
