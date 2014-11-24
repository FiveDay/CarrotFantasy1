using UnityEngine;
using System.Collections;

public class Carrot : MonoBehaviour {

	public Sprite[] lifeSprites;
	public GameObject life;
		
	public int indexOfLife = 10-1;

	public enum States{
		life10,
		life7,
		life6,
		life5,
		life4,
		life3,
		life2,
		life1,
	};
	private int currentIndexOfLife = 10-1;

	private CarrotLife10State life10State = new CarrotLife10State();
	private CarrotLife7State life7State = new CarrotLife7State();
	private CarrotLife6State life6State = new CarrotLife6State();
	private CarrotLife5State life5State = new CarrotLife5State();
	private CarrotLife4State life4State = new CarrotLife4State();
	private CarrotLife3State life3State = new CarrotLife3State();
	private CarrotLife2State life2State = new CarrotLife2State();
	private CarrotLife1State life1State = new CarrotLife1State();

	//The referecne to our state machine
	private FiniteStateMachine<Carrot, Carrot.States> fsm;
	// Use this for initialization
	void Start () {
		fsm = new FiniteStateMachine<Carrot, Carrot.States> (this);
		fsm.RegisterState (life10State);
		fsm.RegisterState (life7State);
		fsm.RegisterState (life6State);
		fsm.RegisterState (life5State);
		fsm.RegisterState (life4State);
		fsm.RegisterState (life3State);
		fsm.RegisterState (life2State);
		fsm.RegisterState (life1State);

		//init State
		fsm.ChangeState (life10State);
	}
	
	// Update is called once per frame
	void Update () {
		life.GetComponent<SpriteRenderer> ().sprite = lifeSprites [indexOfLife];
		fsm.Update ();
	}

	//interface function
	public void ChangeState(States newState) {
		fsm.ChangeState (newState);
	}
}
