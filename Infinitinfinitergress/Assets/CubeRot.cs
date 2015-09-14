using UnityEngine;
using System.Collections;

public class CubeRot : MonoBehaviour {
	Transform[] objs;
	Transform child;
	float a;
	// Use this for initialization
	void Start () {
		objs = gameObject.GetComponentsInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator StartRot() {
		foreach(Transform child in transform) {
			child.BroadcastMessage("Turn");
			yield return new WaitForSeconds(0.1f);
		}
	}
	IEnumerator StopRot() {
		foreach(Transform child in transform) {
			child.BroadcastMessage("Stop");
			yield return new WaitForSeconds(0.5f);
		}
	}
	void Touch() {
		StartCoroutine ("StartRot");
	}
	void UnTouch() {
		//StartCoroutine ("StopRot");
	}
}
