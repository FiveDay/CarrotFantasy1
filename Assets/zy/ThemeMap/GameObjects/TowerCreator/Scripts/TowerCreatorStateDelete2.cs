using UnityEngine;
using System.Collections;

//All states should use the Serializable attribute if you want them to be visible in the inspector
[System.Serializable]
public class TowerCreatorStateDelete2 :FSMState<TowerCreator, TowerCreator.States> {
	
	public override TowerCreator.States StateID {
		get {
			return TowerCreator.States.Delete2;
		}
	}
	
	public override void Enter ()
	{
		Animator animator = this.entity.GetComponent<Animator> ();
		animator.Play("DeleteTowerCreator");
	}
	
	public override void Execute ()
	{

	}
	
	public override void Exit ()
	{
		
	}



}