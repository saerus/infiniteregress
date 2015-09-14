using UnityEngine;
using System.Collections;

public class RoadMover : MonoBehaviour {
	float x;
	// Use this for initialization
	void Start () {
		x = Random.Range (-10f, 10f);
		transform.Translate (x, 0, 30, Space.Self);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, -3, Space.Self);
		if(transform.position.x < -100) {
			Destroy(this.gameObject);
		}
	}
}
