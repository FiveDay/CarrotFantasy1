using UnityEngine;
using System.Collections;

public class TowerCreator : MonoBehaviour {

	public enum States{
		Init,
		Idle,
		Add,
		Delete,
	};
	//By making these public properties, and using [System.Serializable] in the state classes, these will now appear in the inspector
	protected TowerCreatorStateIdle stateIdle = new TowerCreatorStateIdle();
	protected TowerCreatorStateInit stateInit = new TowerCreatorStateInit();
	protected TowerCreatorStateAdd  stateAdd = new TowerCreatorStateAdd();
	protected TowerCreatorStateDelete  stateDelete = new TowerCreatorStateDelete();

	//The referecne to our state machine
	private FiniteStateMachine<TowerCreator, TowerCreator.States> fsm;

	// Use this for initialization
	void Start () {
		fsm = new FiniteStateMachine<TowerCreator, TowerCreator.States> (this);

		fsm.RegisterState(stateInit);
		fsm.RegisterState(stateIdle);
		fsm.RegisterState(stateAdd);
		fsm.RegisterState(stateDelete);

	}

	// Update is called once per frame
	void Update () {
		fsm.Update ();
	}
	//interface function
	public void ChangeState(States newState) {
		fsm.ChangeState (newState);
	}

	//callback function
	public void ChangeToInitState() {
		fsm.ChangeState (States.Init);
	}


	}