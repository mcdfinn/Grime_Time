using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Rigidbody2D phys;
	public GameObject bullet;
	public GameObject realBullet;
	public int bulletSpeed = 20;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		shootBullet ();

	}

	public void shootBullet(){
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			realBullet = Instantiate (bullet);
			realBullet.transform.position = this.transform.position + new Vector3 (0, 5, 0);
			phys = realBullet.GetComponent <Rigidbody2D> ();
			phys.AddForce(new Vector2(0, bulletSpeed), ForceMode2D.Impulse);
			print (phys.velocity);
		
		
		}
	}









}






 //