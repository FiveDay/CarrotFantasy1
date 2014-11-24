//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

public class SmallBullet : MonoBehaviour {



	public float bulletSpeed = 10.0f;
	public int attackValue = 1;
	private float angle = 0.0f;	
	
	public GameObject weaponBottle;


	// Use this for initialization
	void Start () {

		//Quaternion.eulerAngles
		var angles = weaponBottle.transform.rotation.eulerAngles;

		Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D> ();
		rigidbody2D.velocity = new Vector2 (bulletSpeed*Mathf.Cos(angles.z*Mathf.Deg2Rad), bulletSpeed*Mathf.Sin(angles.z*Mathf.Deg2Rad));
		//this.gameObject.transform.Translate(bulletSpeed*Mathf.Cos(angles.z*Mathf.Deg2Rad),bulletSpeed*Mathf.Sin(angles.z*Mathf.Deg2Rad),0);

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D col)
	{
//		if(col.gameObject.tag == "backgroundTag"){
//			Debug.Log ("===========bullet Destroy========,file:smallbullet.cs");
//			//Destroy(this.gameObject);
//		} else if (col.gameObject.tag == "EnemyTag"){
//			Debug.Log ("===========!!!!!!!!bullet Destroy by attack a **enemy** !!!!!========,file:smallbullet.cs");
//			//Destroy(this.gameObject);
//		//	col.gameObject.SendMessage("reduceBlood",attackValue,SendMessageOptions.RequireReceiver);
//		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
//		if (col.gameObject.tag == "Attacker"){
//			Debug.Log ("===========.....bullet Destroy by Attacker ...========,file:smallbullet.cs,OnTriggerExit2D");
//			//Destroy(this.gameObject);
//		} 
	}

	//触发信息检测：
	
	//1:当进入触发器
//	void OnTriggerEnter( Collider other ) {
//		Debug.Log("bullet-collision,file:smallbullet.cs,OnTriggerEnter");
//	}
	
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
			//Destroy(this.gameObject);
			//Debug.Log ("===========bullet Destroy========");
		}
	}
	
	//2:当退出碰撞器
	void OnCollisionExit( Collision collisionInfo ) {
	
	}
	
	//3:当逗留碰撞器
	void OnCollisionStay( Collision collisionInfo ) {
	
	}
}
