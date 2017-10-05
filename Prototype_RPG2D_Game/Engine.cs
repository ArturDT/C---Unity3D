using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {
    
    public int bullet1Damage = 10,//to delete
                enemy1MaxHP = 30,
                enemy1Speed = 2;
    public Hero Hero;

    //-----------Monsters:
    //-------------Rat:
    public float ratMaxHp = 1,
                 ratDefense = 0,
                 ratAttack = 1,
                ratMaxSpeed = 2.5f,
                ratMaxEnergy = 1,
                ratDistanceToHero = 0.5f; //podstawowe to 0,5

    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public Transform porusz (Transform myTransform, float inputY, float inputX) //to delete
    {
        if (inputY < 0 && inputX < 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 135);
        else if (inputY > 0 && inputX > 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 315);
        else if (inputY < 0 && inputX > 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 225);
        else if (inputY > 0 && inputX < 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 45);
        else if (inputY < 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 180);
        else if (inputY > 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 0);
        else if (inputX < 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 90);
        else if (inputX > 0)
            myTransform.localEulerAngles = new Vector3(0, 0, 270);

        return myTransform;
    }
}
