using UnityEngine;
using System.Collections;

public class PlateMove : MonoBehaviour {
	float prox = 0;
	float far = 5;
	float goTo;
	Vector3 pos = new Vector3 ();
	float vel = 0.1f;
	float time;
	// Use this for initialization
	void Start () {
		pos = this.transform.localPosition;
		pos.z = far;
		goTo = far;
		StartCoroutine ("StepBack");
	}
	void SetFar(float _far) {
		time = _far / 50.0f;
	}
	// Update is called once per frame
	void Update () {
		pos.z += (goTo-pos.z)/1f;
		this.transform.localPosition = pos;
	}
	IEnumerator Come() {
		vel = prox;
		while(pos.z> prox) {
			pos.z-=vel;
			yield return new WaitForSeconds(1/100f);
		}
	}
	IEnumerator GoAway() {
		vel = far;
		while(pos.z<far) {
			pos.z+=vel;
			yield return new WaitForSeconds(1/100f);
		}
	}
	IEnumerator Step() {
		yield return new WaitForSeconds (time);
		goTo = prox;
	}
	IEnumerator StepBack() {
		yield return new WaitForSeconds (time);
		goTo = 30;
	}
	void Touch() {
		StopCoroutine ("StepBack");
		StartCoroutine ("Step");
		//goTo = prox;
	}
	void UnTouch() {
		//goTo = far;
		StopCoroutine ("Step");
		StartCoroutine ("StepBack");
	}
}
