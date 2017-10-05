using UnityEngine;
using System.Collections;

public class Character : ObjectInGame
{
    private float maxEnergy;
    private float acctEnergy;
    public Vector2 maxSpeed;
    private float defense;
    private float attack;
    private int attackPenalty;
    private float plusAttachMod;
    private float plusAttachModTime;
    private float plusSpeed;
    private int plusSpeedTime;
    private float plusDef;
    private int plusDefTime;
    private float plusAttack;
    private int plusAttackTime;
    public Rigidbody2D myRigidbody; // zmiana na public
    private Vector2 movement ; //new
    private float inputX, inputY; //new

    void Start()
    {
        Start2();
    }

    void Update()
    {
        Update2();
    }

    public void Update2()
    {
        Update1();
        if (plusDefTime > 0)
            plusDefTime--;
        else
            plusDef = 0;

        if (plusAttackTime > 0)
            plusAttackTime--;
        else
            plusAttack = 0;

        if (plusSpeedTime > 0)
            plusSpeedTime--;
        else
            plusSpeed = 0;

        if (plusAttachModTime > 0)
            plusAttachModTime--;
        else
            plusAttachMod = 0;
    }

    public void Start2()
    {
        Start1();
        movement = new Vector2(1, 1); //new
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdateCharacter()//new
    {
        myRigidbody.velocity = movement;
    }

    public bool acctEnergyPlus (float energy)
    {
        /// <summary> Return true when max energy
        /// /// </summary>
        if (energy < 0)
            return false;
        acctEnergy += energy;
        if (acctEnergy >= maxEnergy)
        {
            acctEnergy = maxEnergy;
            return true;
        }
        return false;
    }

    public bool acctEnergyMinus(float energy)
    {
        /// <summary> Return true when no energy
        /// /// </summary>
        if (energy < 0)
            return false;
        acctEnergy -= energy;
        if (acctEnergy <= 0)
        {
            acctEnergy = 0;
            return true;
        }
        return false;
    }

    public void setMaxSpeed (float speed)
    {
        maxSpeed = new Vector2(speed, speed);
    }

    public Vector2 getMaxSpeed ()
    {
        /// <summary> Return speed minus slowers
        /// /// </summary>
        float speed = maxSpeed.x + (maxSpeed.x * (plusSpeed / 100));
        if (speed < 0)
            return new Vector2 (0,0);
        return new Vector2(speed, speed);
    }

    public void setDefense (float newDefense)
    {
        defense = newDefense;
    }

    public float getDefense ()
    {
        /// <summary> Return defense minus penalty
        /// /// </summary>
        return defense + (defense * (plusDef / 100));
    }

    public void setAttack(float newAttack)
    {
        attack = newAttack;
    }

    public float getAttack ()
    {
        /// <summary> Return attach minus penalty
        /// /// </summary>
        float att = attack + (attack * (plusAttack / 100));
        if (att < 0)
            return 0;
        return att;
    }

    public void setPlusSpeed (int newMinusSpeed, int time)
    {
        /// <summary> Plus speed is speed Penalty
        /// /// </summary>
        plusSpeedTime = time;
        plusSpeed = newMinusSpeed;
    }

    public float getPlusSpeed ()
    {
        return plusSpeed;
    }

    public int getPlusSpeedTime()
    {
        return plusSpeedTime;
    }
    //
    public void setPlusDef(int newMinusDefense, int time)
    {
        /// <summary> Plus defesne is defense Penalty
        /// /// </summary>
        plusDefTime = time;
        plusDef = newMinusDefense;
    }

    public float getPlusDef()
    {
        return plusDef;
    }

    public int getPlusDefTime()
    {
        return plusDefTime;
    }
    //
    public void setPlusAttack(int newPlusAttack, int time)
    {
        /// <summary> Minus atttack is atttack Penalty
        /// /// </summary>
        plusAttackTime = time;
        plusAttack = newPlusAttack;
    }

    public float getPlusAttack()
    {
        return plusAttack;
    }

    public int getPlusAttackTime()
    {
        return plusAttackTime;
    }

    public void setAcctEnergy (float newAccEnergy)
    {
        acctEnergy = newAccEnergy;
    }

    public float getAcctEnergy()
    {
        return acctEnergy;
    }

    public void setMaxEnergy(float newMaxEnergy)
    {
        maxEnergy = newMaxEnergy;
    }


    public float getMaxEnergy()
    {
        return maxEnergy;
    }

    public void setMovement ()
    {
        movement = new Vector2(inputX * maxSpeed.x , inputY * maxSpeed.y);
    }

    public void setInputX (float newX)  //new
    {
        inputX = newX;
    }
    public float getInputX()//new
    {
        return inputX;
    }
    public void setInputY(float newY)//new
    {
        inputY = newY;
    }
    public float getInputY()//new
    {
        return inputY;
    }

    public void porusz()
    {
        /// <summary> Rotate object to move directory
        /// /// </summary>
        if (inputY < 0 && inputX < 0)
            setRotate(135);
        else if (inputY > 0 && inputX > 0)
            setRotate(315);
        else if (inputY < 0 && inputX > 0)
            setRotate(225);
        else if (inputY > 0 && inputX < 0)
            setRotate(45);
        else if (inputY < 0)
            setRotate(180);
        else if (inputY > 0)
            setRotate(0);
        else if (inputX < 0)
            setRotate(90);
        else if (inputX > 0)
            setRotate(270);
    }

}
