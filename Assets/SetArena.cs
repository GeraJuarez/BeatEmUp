﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetArena : MonoBehaviour {
	public GameObject arenaWall;


	public Transform p1,
	p2,
	p3,
	p4;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c) {


		if (c.gameObject.layer == 8) {
			Vector3 arenaPos1 = new Vector3 (this.transform.position.x - 4f, this.transform.position.y, this.transform.position.z);
			Vector3 arenaPos2 = new Vector3 (this.transform.position.x + 4f, this.transform.position.y, this.transform.position.z);
			//GameObject wall1 = Instantiate ( arenaWall, arenaPos1, arenaWall.transform.rotation );
			//wall1.transform.Translate (0, -98, 0);
			Instantiate ( arenaWall, arenaPos1, arenaWall.transform.rotation );
			Instantiate ( arenaWall, arenaPos2, arenaWall.transform.rotation );

			Vector3 arenaPos3;
			GameObject en;
			WalkEnemy we;


			arenaPos3 = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);
			en = Instantiate ( enemy, arenaPos3, enemy.transform.rotation );
			we = en.GetComponent<WalkEnemy> ();
			we.p1 = this.p1;
			we.p2 = this.p2;
			we.p3 = this.p3;
			we.p4 = this.p4;
			we.alwaysAttacks = false;
			we.attacks = true;
			we.moves = true;
			we.defaultSpeed *= 0.5f;

			arenaPos3 = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z + 0.3f);
			en = Instantiate ( enemy, arenaPos3, enemy.transform.rotation );
			we = en.GetComponent<WalkEnemy> ();
			we.p1 = this.p1;
			we.p2 = this.p2;
			we.p3 = this.p3;
			we.p4 = this.p4;
			we.alwaysAttacks = false;
			we.attacks = false;
			we.moves = true;

			arenaPos3 = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z - 0.8f);
			en = Instantiate ( enemy, arenaPos3, enemy.transform.rotation );
			we = en.GetComponent<WalkEnemy> ();
			we.p1 = this.p1;
			we.p2 = this.p2;
			we.p3 = this.p3;
			we.p4 = this.p4;
			we.alwaysAttacks = true;
			we.attacks = false;
			we.moves = false;

			Destroy (this.gameObject);
		}

	}
}