using UnityEngine;
using System.Collections;

public class BgSpawner : MonoBehaviour {
	public int width;
	
	public int height;

	public Transform bgGround;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < width; x++)
			for (int y = 0; y < height; y++) {
				var o = (Transform)GameObject.Instantiate(bgGround, new Vector3 (x, y+this.transform.position.y, this.transform.position.z), Quaternion.identity);
				o.parent = this.transform;
			}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
