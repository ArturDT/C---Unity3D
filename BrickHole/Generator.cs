using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject klocek0, klocek1, klocek2, klocek3, klocek4, klocek5,
					  klocek6, klocek7, klocek8, klocek9, klocek10, klocek11,
					  klocek12, klocek13, klocek14, klocek15, klocek16, klocek17, klocek18;
	public GameObject[] ograniczniki;
	Vector2 pozycja;
	float opoznienie;
	int jakiKlocek;
	int jakiGenerator;
	bool poczatek;

	void Start () {
		opoznienie = 0.1f;
		poczatek = true;
		generujPoczatek ();
		pozycja.y = 15;
		StartCoroutine (SpawnWaves ());
	}
	

	void Update () {

	}

	IEnumerator SpawnWaves ()
	{
		while (true) 
		{
			generujKlocek();
			yield return new WaitForSeconds (opoznienie);
		}
	}

	private void generujPoczatek()
	{
		for (int i = - 9; i < 10; i++)
			for (int j = -2; j < 15; j+=4) 
			{
				pozycja.x = i;
				pozycja.y = j;
				generujKlocek();
			if (jakiKlocek == 0 || jakiKlocek == 3 || jakiKlocek == 4 || (jakiKlocek >= 11 && jakiKlocek <= 16))
				i++;
			else if (jakiKlocek == 1)
				i += 3;
			else if (jakiKlocek != 2)
				i += 2;
			}
		poczatek = false;
	}

	private void generujKlocek()
	{
		jakiKlocek = (int) Random.Range (0, 18);
		if (poczatek == false) {
			pozycja.x = (int)Random.Range (-9, 9);
			jakiGenerator = (int)pozycja.x + 9;
		} else if (pozycja.x > -3 && pozycja.x < 0)
			jakiKlocek = 7;
		else if (pozycja.x >= 0 && pozycja.x < 2)
			jakiKlocek = 8;
		switch (jakiKlocek)
		{
		case 0:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			    && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny)  || poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek0, pozycja, Quaternion.identity);
			}
			break;
		case 1:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +3].GetComponent<Ogranicznik>().aktywny) || poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek1, pozycja, Quaternion.identity);
			}
			break;
		case 2:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny )|| poczatek) 
				Instantiate (klocek2, pozycja, Quaternion.identity);
			break;
		case 3:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny )|| poczatek) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek3, pozycja, Quaternion.identity);
			}
			break;
		case 4:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny)|| poczatek  )
			{
				pozycja.x += 0.5f;
				Instantiate (klocek4, pozycja, Quaternion.identity);
			}
			break;
		case 5:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny  
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny) || poczatek )
				Instantiate (klocek5, pozycja, Quaternion.identity);
			break;
		case 6:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny  
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny )|| poczatek )
				Instantiate (klocek6, pozycja, Quaternion.identity);
			break;
		case 7:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny )|| poczatek )
				Instantiate (klocek7, pozycja, Quaternion.identity);
			break;
		case 8:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny  
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny )|| poczatek )
				Instantiate (klocek8, pozycja, Quaternion.identity);
			break;
		case 9:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny  
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny )|| poczatek )
				Instantiate (klocek9, pozycja, Quaternion.identity);
			break;
		case 10:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny )|| poczatek ) 
				Instantiate (klocek10, pozycja, Quaternion.identity);
			break;
		case 11:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny) || poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek11, pozycja, Quaternion.identity);
			}
			break;
		case 12:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny) || poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek12, pozycja, Quaternion.identity);
			}
			break;
		case 13:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny )|| poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek13, pozycja, Quaternion.identity);
			}
			break;
		case 14:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny) || poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek14, pozycja, Quaternion.identity);
			}
			break;
		case 15:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny )|| poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek15, pozycja, Quaternion.identity);
			}
			break;
		case 16:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny )|| poczatek ) 
			{
				pozycja.x += 0.5f;
				Instantiate (klocek16, pozycja, Quaternion.identity);
			}
			break;
		case 17:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny) || poczatek )
				Instantiate (klocek17, pozycja, Quaternion.identity);
			break;
		case 18:
			if ((ograniczniki[jakiGenerator].GetComponent<Ogranicznik>().aktywny
			     && ograniczniki[jakiGenerator +1].GetComponent<Ogranicznik>().aktywny 
			     && ograniczniki[jakiGenerator +2].GetComponent<Ogranicznik>().aktywny) || poczatek ) 
				Instantiate (klocek18, pozycja, Quaternion.identity);
			break;
		}
	}

	public void mainMenu()
	{
		Application.LoadLevel(0);
	}
}
