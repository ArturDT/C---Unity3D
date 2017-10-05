using UnityEngine;
using System.Collections;

public class ZniszczKlocek : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Klocek") 
		{
			Destroy (other.gameObject);
			//Destroy (gameObject);
		}
	}
}
