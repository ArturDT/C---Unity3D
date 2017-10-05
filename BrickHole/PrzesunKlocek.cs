using UnityEngine;
using System.Collections;

public class PrzesunKlocek : MonoBehaviour {

	public bool spada;
	Rigidbody2D myBody;
	float pozycjaX;
	float a, b, c;

	void Start()
	{
		myBody = this.GetComponent<Rigidbody2D>();
		pozycjaX = myBody.position.x;
		spada = false;
		a =  Random.Range (0.0f, 1.0f);
		b =  Random.Range (0.0f, 1.0f);
		c =  Random.Range (0.0f, 1.0f);
		Color nowy = new Color(a, b, c, 1f); 
		this.GetComponent<SpriteRenderer> ().color = nowy;
	}

	void Update()
	{
		Vector2 pozycja;
		pozycja.x = pozycjaX;
		pozycja.y = myBody.position.y;
		if ((myBody.position.x - pozycjaX) > 0.5f || (myBody.position.x - pozycjaX) < -0.5f)
			Destroy (this.gameObject);
		myBody.position = pozycja;
	}

	void FixedUpdate()
	{
		if (myBody.velocity.y > -0.2f)
			spada = false;
		else
			spada = true;
	}


}
