using UnityEngine;
using System.Collections;

//All states should use the Serializable attribute if you want them to be visible in the inspector
[System.Serializable]
public class TowerCreatorStateIdle :FSMState<TowerCreator, TowerCreator.States> {

	public override TowerCreator.States StateID {
		get {
			return TowerCreator.States.Idle;
		}
	}

	public override void Enter ()
	{

	}
	
	public override void Execute ()
	{
		
	}
	
	public override void Exit ()
	{
		
	}
}
