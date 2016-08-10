using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody2D phys;
	public int forwardSpeed = 10;
	public int moveSpeed = 10;

	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();

	
	}

	
	// Update is called once per frame
	void Update () {
		moveRight ();
		moveForward ();
		moveLeft ();
		moveDown ();
	}
		
	public void moveForward(){
		if (Input.GetKey (KeyCode.W)) {
			phys.velocity = Vector2.up * forwardSpeed;
		}
	
		if (Input.GetKeyUp (KeyCode.W)) {
			phys.velocity = Vector2.zero;
		}
	
	}



	public void moveRight(){
		if (Input.GetKey (KeyCode.D)) {
			phys.velocity = Vector2.right * moveSpeed;
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			phys.velocity = Vector2.zero;
		}
	
	}


	public void moveLeft(){
		if (Input.GetKey (KeyCode.A)) {
			phys.velocity = Vector2.left * moveSpeed;
		}

		if (Input.GetKeyUp (KeyCode.A)) {
			phys.velocity = Vector2.zero;
		}
	
	}


	public void moveDown(){
		if (Input.GetKey (KeyCode.S)) {
			phys.velocity = Vector2.down * moveSpeed;


		}
	
		if (Input.GetKeyUp (KeyCode.S)) {
			phys.velocity = Vector2.zero;
		}
	}		
	








}



