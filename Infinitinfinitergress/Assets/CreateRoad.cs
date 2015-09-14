using UnityEngine;
using System.Collections;

public class CreateRoad : MonoBehaviour {
	bool t = false;
	GameObject temp;
	public Transform parent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(t == true) {
			if(Random.Range(0, 1)<0.3f) {
				temp = GameObject.Instantiate(Resources.Load("RoadObstacle"), Vector3.zero, Quaternion.identity) as GameObject;
				temp.transform.parent = parent;
			}
		}
	}
	void Touch() {
		t = true;
	}
	void UnTouch() {
		t = false;
	}
}
