//this script had been redefined by zhangnan

using UnityEngine;
using System.Collections;

[System.Serializable]

public class LevelupStateOfBottleDefense : FSMState<BottleDefense,BottleDefense.StatesOfDefense> {

	public override BottleDefense.StatesOfDefense StateID {
		get {
			return BottleDefense.StatesOfDefense.LEVELUP;
		}
	}

	public override void Enter () {
		Animator anim = this.entity.GetComponent<Animator>();
		////anim.Play ("BottleIdle");
	}
	
	public override void Execute() {
		this.entity.SendMessage("LevelUp");
	}
	
	public override void Exit () {
		
	}
}
