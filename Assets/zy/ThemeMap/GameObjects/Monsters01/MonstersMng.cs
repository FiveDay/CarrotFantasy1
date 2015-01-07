using UnityEngine;
using System.Collections;

public class MonstersMng : MonoBehaviour {

	public GameObject monster;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartUpMonsterOfFirstWave(){
		GameObject monster01 = GameObject.Instantiate (monster) as GameObject;

        Monsters monsterBeh = monster01.GetComponent<Monsters>();
        monsterBeh.StartAttack();
	}
}
