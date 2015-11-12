using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public AudioSource player;

	private float lastY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var rd = this.GetComponent<Rigidbody2D> ();
		rd.AddForce (new Vector2 (Input.GetAxis ("Horizontal")*10, 0));
		if(Input.GetButton("Fire1"))rd.AddForce(new Vector2(0,100));
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(Mathf.Abs(lastY - this.transform.position.y)>1.0e-1)
			player.Play ();
		lastY = transform.position.y;
	}
}
