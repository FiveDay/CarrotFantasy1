﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class CarrotLife6State : FSMState<Carrot, Carrot.States> {

	public override Carrot.States StateID {
		get {
			return Carrot.States.life6;
		}
	}
	
	public override void Enter () {
		Animator animator = this.entity.GetComponent<Animator> ();
		animator.Play("CarrotLife6");
	}
	
	public override void Execute ()
	{
//		Animator animator = this.entity.GetComponent<Animator> ();
//		if (!animator.GetCurrentAnimatorStateInfo (0).IsName ("CarrotShake")) {
//			this.entity.ChangeState(Carrot.States.life10);
//		}
	}
	
	public override void Exit () {
		
	}
}
