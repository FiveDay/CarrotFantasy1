using UnityEngine;
using System.Collections;

//All states should use the Serializable attribute if you want them to be visible in the inspector
[System.Serializable]
public class TowerCreatorStateAdd :FSMState<TowerCreator, TowerCreator.States> {
	
	public override TowerCreator.States StateID {
		get {
			return TowerCreator.States.Add;
		}
	}
	
	public override void Enter () {
		Animator animator = this.entity.GetComponent<Animator> ();
		animator.Play("AddTowerCreator");

		AudioSource[] audios = this.entity.GetComponents<AudioSource> ();
		audios[0].Play ();
	}
	
	public override void Execute ()
	{

	}
	
	public override void Exit () {
		
	}
}