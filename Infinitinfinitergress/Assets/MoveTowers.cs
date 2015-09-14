using UnityEngine;
using System.Collections;

public class MoveTowers : MonoBehaviour {
	Vector3 pos;
	float vel = 0;
	float velGo = 0;
	Vector3 rot = new Vector3();
	// Use this for initialization
	void Start () {
		pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		//
		/*if (vel < velGo) {
			vel += 0.01f;
		} else if (vel > velGo) {
			vel -= 0.01f;
		}
		//
		pos.y+=vel;
		*/
		pos.y += 2;
		if(pos.y>12) {
			pos.y-=12;
		}
		//rot.x = Mathf.PerlinNoise(123, Time.time)*vel;
		//rot.z = Mathf.PerlinNoise(23424, Time.time)*vel;
		transform.localPosition = pos;
		//transform.localRotation = Quaternion.Euler (rot);
	}
	void Touch() {
		velGo = 5;
	}
	void UnTouch() {
		velGo = 0;
	}
}
