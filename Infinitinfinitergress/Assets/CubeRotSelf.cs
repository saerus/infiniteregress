using UnityEngine;
using System.Collections;

public class CubeRotSelf : MonoBehaviour {
	bool turn = false;
	Material mat;
	float val;
	// Use this for initialization
	void Start () {
		mat = GetComponent<Renderer>().material;

	}
	// Update is called once per frame
	IEnumerator TurnOnce() {
		turn = true;
		for(int i=0; i<10; i++) {
			transform.Rotate(0, 0, 20/10);
			val = (1-i/10f);
			Color finalColor = new Color (val, val, val, val);
			mat.SetColor("_Color", finalColor);
			mat.SetColor("_EmissionColor", finalColor);
			yield return new WaitForSeconds(0.01f);
		}
		turn = false;
	}
	void Turn() {
		if(!turn) {
			StartCoroutine("TurnOnce");
		}
	}
	void Stop() {
		//turn = false;
	}
}
