//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private int enemyBloodCount;

	// Use this for initialization
	void Start () {
		enemyBloodCount = 100;
	}

	//interface
	void reduceBlood(int bloodReduceCount)
	{
		enemyBloodCount -= bloodReduceCount;

		if (enemyBloodCount <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		float distance = Time.deltaTime * 1;
		gameObject.transform.Translate(Vector3.right*distance);

		if(gameObject.transform.position.x > 5.2)
		{
			gameObject.transform.position = new Vector3(-5.2f,gameObject.transform.position.y,gameObject.transform.position.z);
		}
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

	//触发信息检测：

	//1:当进入触发器
	//void OnTriggerEnter( Collider other ) {
	//
	//}

	//2:当退出触发器
	//void OnTriggerExit( Collider other ) {
	//
	//}

	//3:当逗留触发器
	//void OnTriggerStay( Collider other ) {
	//
	//}


	//碰撞信息检测：

	//1:当进入碰撞器
	//void OnCollisionEnter( Collision collisionInfo ) {
	//
	//}

	//2:当退出碰撞器
	//void OnCollisionExit( Collision collisionInfo ) {
	//
	//}

	//3:当逗留碰撞器
	//void OnCollisionStay( Collision collisionInfo ) {
	//
	//}  
}
