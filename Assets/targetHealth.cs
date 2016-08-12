using UnityEngine;
using System.Collections;

public class targetHealth : MonoBehaviour {

	public int healthTarget = 100;
	public int bulletDamage = 50;
	public GameObject bullet;
	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()  {
		ryanIsADummy ();
	}
	// he really is
	void ryanIsADummy(){
		if (healthTarget < 1) {
			Destroy(target);
		}
	}
	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "bullet"){
			healthTarget = healthTarget - bulletDamage;

		}
	}
}