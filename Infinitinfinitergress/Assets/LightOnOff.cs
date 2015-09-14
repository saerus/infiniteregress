using UnityEngine;
using System.Collections;

public class LightOnOff : MonoBehaviour {
	float val = 0;
	float valGo = 0;
	Material mat;
	float vel = 0.1f;
	float part = 0.9f;
	// Use this for initialization
	void Start () {
		mat = GetComponent<Renderer>().material;
	}
	IEnumerator Big() {
		valGo = 1;
		yield return new WaitForSeconds(Random.Range(0f, 0.5f));
		while (val<valGo) {
			val+=vel;
			yield return new WaitForSeconds(1/50f);
		}
	}
	IEnumerator Small() {
		valGo = 0;
		while (val>valGo) {
			val-=vel;
			yield return new WaitForSeconds(1/50f);
		}
	}
	void Update () {
		Color finalColor = new Color (val*part, val*part, val*part, val);
		mat.SetColor("_Color", finalColor);
		mat.SetColor("_EmissionColor", finalColor);
	}
	void Touch() {
		StopCoroutine ("Small");
		StartCoroutine ("Big");
	}
	void UnTouch() {
		StopCoroutine ("Big");
		StartCoroutine ("Small");
	}
}
