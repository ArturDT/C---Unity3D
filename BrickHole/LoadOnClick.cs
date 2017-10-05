using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public GameObject ExitButton;
	public GameObject StartButton;

	public void start(int level)
	{
		Application.LoadLevel(level);
	}

	public void exit()
	{
		Application.Quit ();
	}

}
