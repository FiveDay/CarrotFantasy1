using UnityEngine;
using System.Collections;

public class Blood : MonoBehaviour {


	public Transform blue;

	private float bloodValue = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float k = bloodValue / 10.0f;

		blue.transform.localScale = new Vector3(1, 1-k, 1);

	}

	public float getBloodValue()
	{
		return bloodValue;
	}

	public void AddBlood ()
	{
		bloodValue ++;
		if (bloodValue > 10)
			bloodValue = 10;
	}

	public void LoseBlood ()
	{
		bloodValue --;
		if(bloodValue <=0)
			bloodValue = 0;
	}
}
