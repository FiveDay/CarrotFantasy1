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
				
		Vector3 targetVector = this.entity.gameObject.transform.position - this.entity.vecOld;
		var forward = this.entity.gameObject.transform.forward;
		var angle = Vector3.Angle(targetVector, forward);
		
		SpriteRenderer myspriteRender = this.entity.gameObject.GetComponent<SpriteRenderer>();
		myspriteRender.transform.Rotate(0,0,/*180-angle * 180.0f/Mathf.PI*/-1);




		this.entity.SendMessage("createBullet");
	}
}
