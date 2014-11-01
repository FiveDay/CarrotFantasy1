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
		anim.Play ("BottleIdle");
	}

	public override void Execute() {
	}

	public override void Exit () {
		
	}
}
