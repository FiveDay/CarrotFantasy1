//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class MidBullet : MonoBehaviour {

	public float bulletSpeed;
	public int attackValue;

	private Transform bulletTransform;

	private float angle;

	void setAngle(float newAngle)
	{
		angle = newAngle;
	}

	// Use this for initialization
	void Start () {
		bulletTransform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		float amtToMove = bulletSpeed * Time.deltaTime;

		//Vector3.

		//bulletTransform.Translate(Vector3.right * amtToMove));
		bulletTransform.position = new Vector3 (bulletTransform.position.x + amtToMove * Mathf.Cos(angle), //1/Mathf.Tan(angle),
		                                        bulletTransform.position.y + amtToMove * Mathf.Sin(angle),//Mathf.Tan(angle),
		                                        bulletTransform.position.z);
		
//		if(transform.position.x > 4.3)
//		{
//			Destroy(this.gameObject);
//			Debug.Log ("===========bullet Destroy========");
//		}
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
		Debug.Log("bullet-collision");
		if(col.gameObject.tag == "backgroundTag"){
			Debug.Log ("===========bullet Destroy========");
			Destroy(this.gameObject);
		} else if (col.gameObject.tag == "EnemyTag"){
			Debug.Log ("===========!!!!!!!!bullet Destroy by attack a **enemy** !!!!!========");
			Destroy(this.gameObject);
			col.gameObject.SendMessage("reduceBlood",attackValue,SendMessageOptions.RequireReceiver);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Attacker"){
			Debug.Log ("===========.....bullet Destroy by Attacker ...========");
			Destroy(this.gameObject);
		} 
	}

	//触发信息检测：
	
	//1:当进入触发器
	void OnTriggerEnter( Collider other ) {
		Debug.Log("bullet-collision");
	}
	
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
	void OnCollisionEnter( Collision collisionInfo ) {
		if(collisionInfo.gameObject)
		{
			Destroy(this.gameObject);
			Debug.Log ("===========bullet Destroy========");
		}
	}
	
	//2:当退出碰撞器
	void OnCollisionExit( Collision collisionInfo ) {
	
	}
	
	//3:当逗留碰撞器
	void OnCollisionStay( Collision collisionInfo ) {
	
	}
}
