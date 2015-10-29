using UnityEngine;
using System.Collections;

public class YFix : MonoBehaviour {
	private float initialY;
	// Use this for initialization
	void Start () {
		this.initialY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x, this.initialY, this.transform.position.z);
		this.transform.rotation = Quaternion.identity;
	}
}
