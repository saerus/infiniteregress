using UnityEngine;
using System.Collections;

public class Temporaire : MonoBehaviour {
	float life = Random.Range(0.1f, 1f);
	SphereCollider sc;
	// Use this for initialization
	void Start () {
		this.transform.Translate(Random.Range(-1, 1), 0, Random.Range(-1, 1));
		StartCoroutine ("DeathSentence");
		sc = gameObject.GetComponent<SphereCollider>();
		//sc.radius = Random.Range(1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator DeathSentence() {
		yield return new WaitForSeconds(life/2);
		sc.radius = Random.Range(0.1f, 1f);
		yield return new WaitForSeconds(life/2);
		Destroy(this.gameObject);
	}
}
