using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDestroy : MonoBehaviour {

	public GameObject boom;
	public GameObject playerBoom;
	GameObject GameControl;
	GameControl kontrol;
	void Start()
	{
		GameControl = GameObject.FindGameObjectWithTag("GameControl");
		kontrol = GameControl.GetComponent<GameControl> ();

	}




	void OnTriggerEnter (Collider col)
	{
		if (col.tag != "Border")
		{
			Destroy (col.gameObject);
			Destroy (gameObject);
			Instantiate (boom,transform.position,transform.rotation);
			kontrol.ScoreArttır (10);
		}
		if (col.tag == "Player")
		{
		
			Instantiate (playerBoom,col.transform.position,col.transform.rotation);
			kontrol.gameOver ();

		}

	}

}
