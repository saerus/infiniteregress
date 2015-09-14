using UnityEngine;
using System.Collections;

public class MakeItBigger : MonoBehaviour {
	float val = 0;
	float valGo = 0;
	SphereCollider sc;
	public float vel = 0.1f;
	public float maxSize = 20;
	public GameObject sph;
	// Use this for initialization
	void Start () {
		sc = this.gameObject.GetComponent<SphereCollider>();
	}
	IEnumerator Big() {
		valGo = maxSize;
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
	// Update is called once per frame
	void Update () {
		/*if(val < valGo) {
			val+=speed;
		} else if(val > valGo) {
			val-=speed;
		}
		//sc.radius = val * 10;
		*/
		sph.transform.localScale = new Vector3 (val, val, val);
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
