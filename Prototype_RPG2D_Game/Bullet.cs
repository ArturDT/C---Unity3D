using UnityEngine;
using System.Collections;

public class Bullet : ObjectInGame
{
    private float speedX, speedY, speed;
    private float lifetime;

    void Start () {
        Start1();
        Destroy(gameObject, lifetime);
        while (getRotate() > 360)
            setRotate(getRotate() - 360);
        if (getRotate() < 45)
        {
            speedX = 0;
            speedY = speed;
        }
        else if (getRotate() < 90)
        {
            speedX = speed / 2;
            speedY = speed / 2;
        }
        else if (getRotate() < 135)
        {
            speedX = -speed;
            speedY = 0;
        }
        else if (getRotate() < 180)
        {
            speedX = -speed / 2;
            speedY = speed / 2;
        }
        else if (getRotate() < 225)
        {
            speedX = 0;
            speedY = -speed;
        }
        else if (getRotate() < 270)
        {
            speedX = -speed / 2;
            speedY = -speed / 2;
        }
        else if (getRotate() < 315)
        {
            speedX = speed;
            speedY = 0;
        }
        else {
            speedX = speed / 2;
            speedY = -speed / 2;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject, 0);
            //Destroy(col.gameObject);
        }

    }

    void Update () {
        // Update1();
        setPos(getPosX() + speedX, getPosY() + speedY);
    }

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public float getSpeed()
    {
        return speed;
    }

    public void setLifeTime(float newLifeTime)
    {
        lifetime = newLifeTime;
    }

    public float getLifeTime()
    {
        return lifetime;
    }

}
