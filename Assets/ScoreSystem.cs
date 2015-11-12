using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour {

	public Transform stageOrigin;

	public Transform player;

	public Text textUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textUI.text = string.Format("{0}m",Mathf.Floor(Mathf.Abs(this.stageOrigin.position.x - this.player.position.x)));
	}
}
