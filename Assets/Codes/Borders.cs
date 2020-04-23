using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{

	void OnTriggerExit (Collider col)
	{
		Destroy (col.gameObject);
	}

}
