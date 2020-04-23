using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour {

	public GameObject AsteroidPlace;
	public Vector3 randomPos;
	public float startWait;
	public float createWait;
	public float loopWait;
	public Text text;
	int score;
	bool gameOverControl=false;
	bool newGameControl=false;
	public Text text2;
	public Text text3;
	void Start () 
	{
		
		StartCoroutine (olustur());
		score = 0;
		text.text = "Score = " + score;
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.R) && newGameControl)
		{
			SceneManager.LoadScene ("Level 1");

		}
	}
	IEnumerator olustur()
	{
		yield return new WaitForSeconds (startWait);
		while (true) 
		{
			for (int i = 0; i < 10; i++) {
				Vector3 vec = new Vector3 (Random.Range (-randomPos.x, randomPos.x), 0, randomPos.z);
				Instantiate (AsteroidPlace, vec, Quaternion.identity);
				yield return new WaitForSeconds (createWait);
			}
			if (gameOverControl) 
			{

				text3.text = "Press R button for restart ";
				newGameControl = true;
				break;
			}
			yield return new WaitForSeconds (loopWait);

		}
	}
	public void ScoreArttır(int gelenScore)
	{ 
		score += gelenScore;
		text.text = "Score = " + score;
		Debug.Log (score);
	}
	public void gameOver() 
	{
		text2.text = "GAME OVER";
		gameOverControl = true;
	}

}
