using UnityEngine;
using System.Collections;

//All states should use the Serializable attribute if you want them to be visible in the inspector
[System.Serializable]
public class TowerCreatorStateDelete :FSMState<TowerCreator, TowerCreator.States> {
	
	public override TowerCreator.States StateID {
		get {
			return TowerCreator.States.Delete;
		}
	}
	
	public override void Enter ()
	{
		Animator animator = this.entity.GetComponent<Animator> ();
		animator.Play("DeleteTowerCreator");

		//AnimationInfo[] animatorStateInfos = animator.GetCurrentAnimationClipState (0);
		//AnimationInfo info = animatorStateInfos [0];
		//AnimationClip clip = info.clip;

		//AnimationEvent aevent = new AnimationEvent();
		//aevent.functionName = "ChangeToInitState"; //方法名
		//aevent.time = 10;
		//clip.AddEvent (aevent);


		AudioSource[] audios = this.entity.GetComponents<AudioSource> ();
		audios[1].Play ();
	}
	
	public override void Execute ()
	{

	}
	
	public override void Exit ()
	{
		
	}



}