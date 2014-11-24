//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

[System.Serializable]

public class IdleStateOfBottleDefense : FSMState<BottleDefense,BottleDefense.StatesOfDefense> {

	public override BottleDefense.StatesOfDefense StateID {
		get {
			return BottleDefense.StatesOfDefense.IDLE;
		}
	}

	public override void Enter () {
		Animator anim = this.entity.GetComponent<Animator>();

		int iLevel = this.entity.bottleLevel;
		switch(iLevel)
		{
		case 1:
			anim.Play ("BottleIdle");
			break;
		case 2:
			anim.Play ("Level2BottleIdle");
			break;
		case 3:
			break;
		default:
			Debug.Break();
			break;
		}

	}

	public override void Execute() {
	}

	public override void Exit () {
		
	}
}
