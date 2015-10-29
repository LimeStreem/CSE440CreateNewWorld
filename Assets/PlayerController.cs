using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var rd = this.GetComponent<Rigidbody2D> ();
		rd.AddForce (new Vector2 (Input.GetAxis ("Horizontal")*10, 0));
		if(Input.GetButton("Fire1"))rd.AddForce(new Vector2(0,100));
	}
}
