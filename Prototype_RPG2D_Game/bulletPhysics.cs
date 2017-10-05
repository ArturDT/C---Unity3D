using UnityEngine;
using System.Collections;

public class bulletPhysics : Physics
{

    private Transform myTransform;
    public float speed;
    public float speedX, speedY;
    public int rotate;
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
        myTransform = GetComponent<Transform>();
        rotate = (int)myTransform.rotation.eulerAngles.z;
        rotate = setRotateUnder360(rotate);
        speedX = setSpeedXInCreate(rotate, speed);
        speedY = setSpeedYInCreate(rotate, speed);
    }


    void Update()
    {
        myTransform.position = new Vector3(myTransform.position.x + speedX, myTransform.position.y + speedY, 0);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
        Destroy(gameObject, 0);
        //Destroy(col.gameObject);
        }

    }
}
