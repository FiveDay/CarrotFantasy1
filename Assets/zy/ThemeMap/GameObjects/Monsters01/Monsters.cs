using UnityEngine;
using System.Collections;

using CBX.TileMapping.Unity;

public class Monsters : MonoBehaviour {

	public Blood blood;
    public TileMap map;
    private Transform[] roadTransfoms;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (blood.getBloodValue() == 0){
			Destroy(this.gameObject);
			return;
		}

	}

	//Trigger callback function
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Carrot") {
			Destroy (this.gameObject);
			return;
		}
		if(col.tag == "BulletTag")
			blood.LoseBlood ();
	}

    public void StartAttack()
    {
        int index = 0;
        roadTransfoms = new Transform[map.RoadTiles.Length];
        foreach (Transform tran in map.RoadTiles)
        {
            roadTransfoms[index] = tran;
            index++;
        }

        Hashtable args = new Hashtable();
        //设置路径的点
        args.Add("path", roadTransfoms);
        //设置类型为线性，线性效果会好一些。
        args.Add("easeType", iTween.EaseType.linear);
        //设置寻路的速度
        args.Add("speed", 1f);
        //是否先从原始位置走到路径中第一个点的位置
        args.Add("movetopath", false);
        //是否让模型始终面朝当面目标的方向，拐弯的地方会自动旋转模型
        //如果你发现你的模型在寻路的时候始终都是一个方向那么一定要打开这个
        args.Add("orienttopath", false);

        //让模型开始寻路
        iTween.MoveTo(gameObject, args);

        Animator animator = this.GetComponent<Animator>();
        animator.Play("Fly", 0);
    }
}
