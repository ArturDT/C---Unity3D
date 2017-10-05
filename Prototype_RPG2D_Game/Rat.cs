using UnityEngine;
using System.Collections;

public class Rat : Monster {

	// Use this for initialization
	void Start () {
        Start3();
        setMaxHp(engine.ratMaxHp);
        setMaxSpeed(engine.ratAttack);
        setDefense(engine.ratDefense);
        setMaxSpeed(engine.ratMaxSpeed);
        setMaxEnergy(engine.ratMaxEnergy);
        setDistanceToHero(engine.ratDistanceToHero);
    }
	
	// Update is called once per frame
	void Update () {
        Update3();
    }

    public void OnCollisionEnter2D(Collision2D col) //new
    {
        OnCollisionEnter2DMonster(col);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        OnTriggerEnter2DMonster(col);
    }

    void FixedUpdate()
    {
        FixedUpdateCharacter();
    }
}
