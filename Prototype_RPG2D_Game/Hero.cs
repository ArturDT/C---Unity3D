using UnityEngine;
using System.Collections;

public class Hero : Character {

    public Engine engine; 
    private int lastKat;
    // Use this for initialization
    void Start () {
        Start2();
       
    }
	

	void Update () {
        Update2();
        setInputX(Input.GetAxis("Horizontal"));
        setInputY(Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Debug.Log("press shift");
        }
        else
        {
            porusz();
        }
        setMovement();
    }
    void FixedUpdate()
    {
        FixedUpdateCharacter();
    }
}
