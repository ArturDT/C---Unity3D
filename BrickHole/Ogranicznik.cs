using UnityEngine;
using System.Collections;

public class Ogranicznik : MonoBehaviour {

	public bool aktywny;

	void Start()
	{
		aktywny = true;
	}

	void Update ()
	{
		//if (this.GetComponent<Collider2D>().IsTouching() == false)
		//	aktywny = true;
		StartCoroutine (poprawka ());
	}

	IEnumerator poprawka ()
	{
		while (true) 
		{
			aktywny = true;
			yield return new WaitForSeconds (50);
		}
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Klocek") {
			if (aktywny == true)
			{
				aktywny = false;
			}
			else 
			{
				Destroy (other.gameObject);
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		//if (other.tag == "Klocek") {
			aktywny = true;
		//}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Klocek") {
			aktywny = false;
		}
	}

}
