using UnityEngine;
using System.Collections;

public class ObjectInGame : MonoBehaviour {

    private float MaxHP,
                  AcctHP;
    private Transform myTransform;

    void Start()
    {
        Start1();
    }
    void Update()
    {
        Update1();
    }

    public void Update1()
    {

    }

    public void Start1()
    {
        myTransform = GetComponent<Transform>();
    }

    public void setMaxHp(float newMaxHP)
    {
        MaxHP = newMaxHP;
    }

    public float getMaxHP()
    {
        return MaxHP;
    }

    public void setAcctHP(float newAcctHP)
    {
        AcctHP = newAcctHP;
    }

    public float getAcctHP()
    {
        return AcctHP;
    }

    public bool getDamage(float damage) //zwraca true jeżeli obiekt zniszczony
    {
        /// <summary> Return true when object destroyed
        /// /// </summary>
        if (damage < 0)
            return false;
        AcctHP -= damage;
        if (AcctHP <= 0)
        {
            Destroy(gameObject, 0);
            return true;
        }
        return false;          
    }

    public bool heal(float heal) //zwraca true jeżeli w pełni wyleczony
    {
        /// <summary> Return true when fully healted
        /// /// </summary>
        if (heal < 0)
            return false;
        AcctHP += heal;
        if (AcctHP >= MaxHP)
        {
            AcctHP = MaxHP;
            return true;
        }
        return false;
    }

    public void setPos (float x, float y)
    {
        myTransform.position = new Vector3 (x, y, 0);
    }

    public void setRotate(float z)
    {
        myTransform.localEulerAngles = new Vector3(0, 0, z);
    }

    public float getPosX ()
    {
        return myTransform.position.x;
    }

    public float getPosY()
    {
        return myTransform.position.y;
    }
    public float getRotate()
    {
        /// <summary> Return actual rotate in degree
        /// /// </summary>
        return myTransform.localEulerAngles.z;
    }

    public void moveX (float x)
    {
        myTransform.position = new Vector3(getPosX() + x, getPosY(), 0);
    }

    public void moveY (float y)
    {
        myTransform.position = new Vector3(getPosX(), getPosY() + y, 0);
    }

    public void rotate (float z) 
    {
        /// <summary> Rotate in degree
        /// /// </summary>
        myTransform.localEulerAngles = new Vector3(0, 0, getRotate() + z);
    }

}
