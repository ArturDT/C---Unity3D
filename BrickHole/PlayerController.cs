using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float szybkosc;	
	public GameObject punkty;
	Rigidbody2D myBody;
	float yInput = 0, xInput = 0;
	bool zamrozenie;
	private int iloscPKT;
	public GameObject przegrana;
	public bool poruszaj;
	public GameObject menuButton;

	void Start()
	{
		myBody = this.GetComponent<Rigidbody2D>();
		zamrozenie = false;
		iloscPKT = 0;
	}

	void FixedUpdate ()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
			mainMenu ();
		if (zamrozenie == false)
			ruch (yInput, xInput);
	}


	public void animacjaRuchu(bool ruch)
	{
		this.GetComponent<Animator> ().enabled = ruch;
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Klocek") 
		{
			if (other.GetComponent<PrzesunKlocek>().spada == false)
			{
				Destroy (other.gameObject);
				dodajPunkt();
			}
			else 
				koniecGry();
		}
		if (other.tag == "Sufit") 
		{
			zamrozenie = true;
			ruch (-1,0);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Sufit") 
		{
			poruszajPoY(0);
			zamrozenie = false;
		}
	}


	private void ruch(float yInput, float xInput)
	{
		ruchY (yInput);
		ruchX (xInput);
	}

	private void ruchY(float horizonalInput)
	{
		poruszaj = true;
		Vector2 moveVel = myBody.velocity;
		moveVel.y =  horizonalInput * szybkosc;;
		myBody.velocity = moveVel;
	}

	private void ruchX(float verticalInput)
	{
		poruszaj = true;
		Vector2 moveVel = myBody.velocity;
		moveVel.x =  verticalInput * szybkosc;;
		myBody.velocity = moveVel;
	}
	

	public void poruszajPoY(float horizonalInput)
	{
		yInput = horizonalInput;
	}

	public void poruszajPoX(float verticalInput)
	{
		xInput = verticalInput;
	}

	public void mainMenu()
	{
		Application.LoadLevel(0);
	}

	void dodajPunkt()
	{
		iloscPKT++;
		punkty.GetComponent<Text> ().text = iloscPKT.ToString() + " points ";
	}

	void koniecGry ()
	{
		Vector2 pozycja;
		pozycja.y = myBody.position.y;
		pozycja.x = myBody.position.x;
		Instantiate (przegrana, pozycja, Quaternion.identity);
		gameObject.SetActive (false);
		menuButton.SetActive (true);

	}


}
