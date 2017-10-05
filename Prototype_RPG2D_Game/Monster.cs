using UnityEngine;
using System.Collections;

public class Monster : Character
{
    int monsterType;
    //loot
    public Engine engine; //new
    private bool canMove; //new
    private bool isOdbojX, isOdbojY;
    private float odbojX, odbojY;
    public float distanceToHero;


    void Start () {
        Start3();
	}

    public void Start3()
    {
        Start2();
        setCanMove(false); //new
        setisOdbojX(false);
        setisOdbojY(false);
    }

    void Update () {
        Update3();
      
    }

    public void Update3()
    {
        Update2();
        if (canMove == true)
        {
            if (getisOdbojX() == true)
            {
                if (getodbojX() > 0)
                {
                    setInputX(1);
                    decodbojX();
                }
                else if (getodbojX() < 0)
                {
                    setInputX(-1);
                    incodbojX();
                }

                if (getodbojX() == 0)
                {
                    setisOdbojX(false);
                    if (getodbojY() != 0)
                        setisOdbojY(true);
                }
            }
            else if (getisOdbojY() == true)
            {
                if (getodbojY() > 0)
                {
                    setInputY(1);
                    decodbojY();
                }
                else if (getodbojY() < 0)
                {
                    setInputY(-1);
                    incodbojY();
                }

                if (getodbojY() == 0)
                {
                    setisOdbojY(false);
                    if (getodbojX() != 0)
                        setisOdbojX(true);
                }
            }
            else
            {
                if (engine.Hero.transform.position.x < (myRigidbody.position.x - distanceToHero))
                {
                    setInputX(-1);
                }
                else if (engine.Hero.transform.position.x > (myRigidbody.position.x + distanceToHero))
                {
                    setInputX(1);
                }
                else
                    setInputX(0);

                if (engine.Hero.transform.position.y < (myRigidbody.position.y - distanceToHero))
                {
                    setInputY(-1);
                }
                else if (engine.Hero.transform.position.y > (myRigidbody.position.y + distanceToHero))
                {
                    setInputY(1);
                }
                else
                    setInputY(0);
            }

            porusz();

        }
        setMovement();
    }

    public void OnCollisionEnter2DMonster(Collision2D col) //new
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            getDamage(engine.bullet1Damage);
        }
    }

    public void OnTriggerEnter2DMonster(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            setCanMove(true);
    }

    public bool getCanMove()  //new
    {
        return canMove;
    }

    public void setCanMove(bool can) //new
    {
        canMove = can;
    }

    public bool getisOdbojX()  //new
    {
        return isOdbojX;
    }

    public void setisOdbojX(bool can) //new
    {
        isOdbojX = can;
    }

    public bool getisOdbojY()  //new
    {
        return isOdbojY;
    }

    public void setisOdbojY(bool can) //new
    {
        isOdbojY = can;
    }

    public float getDistanceToHero()
    {
        return distanceToHero;
    }

    public void setDistanceToHero(float newDist)
    {
        distanceToHero = newDist;
    }

    public float getodbojX()
    {
        return odbojX;
    }

    public void setodbojX(float odboj)
    {
        odbojX = odboj;
    }
    public void incodbojX()
    {
        odbojX++;
    }
    public void decodbojX()
    {
        odbojX--;
    }
    public void incodbojY()
    {
        odbojY++;
    }
    public void decodbojY()
    {
        odbojY--;
    }

    public float getodbojY()
    {
        return odbojY;
    }

    public void setodbojY(float odboj)
    {
        odbojY = odboj;
    }
}
