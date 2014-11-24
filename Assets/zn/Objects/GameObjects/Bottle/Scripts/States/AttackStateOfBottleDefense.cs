//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

[System.Serializable]
public class AttackStateOfBottleDefense : FSMState<BottleDefense,BottleDefense.StatesOfDefense> {

	public override BottleDefense.StatesOfDefense StateID {
		get {
			return BottleDefense.StatesOfDefense.ATTACK ;
		}
	}

	public override void Enter ()
	{
		Animator anim = this.entity.GetComponent<Animator>();

		int iLevel = this.entity.bottleLevel;
		switch(iLevel)
		{
		case 1:
			anim.Play ("BottleAttackAnim");
			anim.Play("BulletMng", 1);
			break;
		case 2:
			anim.Play ("Level2BottleAttackAnim");
			break;
		case 3:
			break;
		default:
			Debug.Break();
			break;
		}

	}
	
	public override void Execute()
	{
		GameObject enemy = this.entity.enemyArray[0] as GameObject;
		GameObject weaponBottle = this.entity.weaponBottle;	
	
		Quaternion changeToRotation = Quaternion.identity;
		Vector3 dir = enemy.transform.position - weaponBottle.transform.position;

		float angle = Vector3.Angle(Vector3.right, dir);
		changeToRotation.eulerAngles = new Vector3 (0, 0, angle);
		float speed = 100.0f;
		weaponBottle.transform.rotation = Quaternion.RotateTowards(weaponBottle.transform.rotation, changeToRotation, speed*Time.deltaTime);
	}
}
