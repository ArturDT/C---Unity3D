using UnityEngine;
using System.Collections;

public class weaponShooter : MonoBehaviour {

    public GameObject shot;
    public float fireRate;
    private float nextFire;
    private Transform myTransform;

    void Start () {
        myTransform = GetComponent<Transform>();
    }
	
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            Instantiate(shot, myTransform.position, myTransform.rotation);
        }
    }
}
