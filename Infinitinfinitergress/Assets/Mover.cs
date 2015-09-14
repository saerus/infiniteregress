using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	//public Vector3 movement = new Vector3(0, 0, 0.04);
	Vector3 pos = new Vector3();

	// Use this for initialization
	void Start () {
		foreach(Transform child in transform) {
			child.gameObject.SetActive(false);
		}
	}
	// Update is called once per frame
	void Update () {

	}
	IEnumerator come() {
		yield return new WaitForSeconds (Random.Range(0f, 2f));
		foreach(Transform child in transform) {
			child.gameObject.SetActive(true);
		}

	}
	IEnumerator go() {
		yield return new WaitForSeconds (Random.Range(0f, 2f));
		foreach(Transform child in transform) {
			child.gameObject.SetActive(false);
		}

	}
	void Touch() {
		StopCoroutine ("go");
		StartCoroutine ("come");
	}
	void UnTouch() {
		StopCoroutine ("come");
		StartCoroutine ("go");

	}
}
