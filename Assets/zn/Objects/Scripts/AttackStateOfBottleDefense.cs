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
		this.entity.SendMessage("createBullet");
	}
}
