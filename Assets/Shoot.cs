using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject character;
	public Rigidbody2D phys;
	public GameObject bullet;
	public GameObject realBullet;
	public int bulletSpeed = 20;
	public Camera shootCamera;
	public Vector2 mousePos;
	public int tickCount;
	public int autoDelay = 2;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tickCount++;
		shootBullet ();
		shootBulletAuto ();
		mousePos = Input.mousePosition;
	}

	public void shootBullet(){
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Vector3 origin = character.transform.position;
			Vector3 spawnPos = new Vector3 (mousePos.x, mousePos.y, -shootCamera.transform.position.z);
			Vector3 target = shootCamera.ScreenToWorldPoint(spawnPos);
			realBullet = Instantiate (bullet);
			Vector3 shotDir = shotDirection (target, origin);
			realBullet.transform.position = origin + shotDir * 5;
			phys = realBullet.GetComponent <Rigidbody2D> ();
			phys.AddForce(shotDir * bulletSpeed, ForceMode2D.Impulse);
		
		
		}
	}

	public Vector3 shotDirection(Vector3 target, Vector3 origin) {
		//print (target);
		//print (origin);
		return (target - origin).normalized;

	}


	public void shootBulletAuto(){
		if (Input.GetKey (KeyCode.Mouse1) && tickCount >= autoDelay) {
			tickCount = 0;
			Vector3 origin = character.transform.position;
			Vector3 spawnPos = new Vector3 (mousePos.x, mousePos.y, -shootCamera.transform.position.z);
			Vector3 target = shootCamera.ScreenToWorldPoint(spawnPos);
			realBullet = Instantiate (bullet);
			Vector3 shotDir = shotDirection (target, origin);
			realBullet.transform.position = origin + shotDir * 5;
			phys = realBullet.GetComponent <Rigidbody2D> ();
			phys.AddForce(shotDir * bulletSpeed, ForceMode2D.Impulse);


		}
	}




}





 // dj ryry will always live on in our hearts along with harambe