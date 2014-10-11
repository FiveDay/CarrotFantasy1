using UnityEngine;
using System.Collections;

//All states should use the Serializable attribute if you want them to be visible in the inspector
[System.Serializable]
public class TowerCreatorStateInit :FSMState<TowerCreator, TowerCreator.States> {
	
	public override TowerCreator.States StateID {
		get {
			return TowerCreator.States.Init;
		}
	}
	
	public override void Enter ()
	{
		this.entity.transform.position = new Vector3 (1000, 1000, 0);
	}
	
	public override void Execute ()
	{
		
	}
	
	public override void Exit ()
	{
		
	}
}
