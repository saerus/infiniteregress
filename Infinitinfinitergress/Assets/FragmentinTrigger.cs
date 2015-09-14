using UnityEngine;
using System.Collections;

public class FragmentinTrigger : MonoBehaviour {
	Collider collider;
	bool touch;
	public string tag = "HAND";
	public GameObject sendTo;
	public bool forceAction = false;
	// Use this for initialization
	void Start () {
		if(sendTo == null) {
			sendTo = this.gameObject;
		}
		if(forceAction) {
			sendTo.BroadcastMessage("Touch");
		}
	}
	// Update is called once per frame
	void Update () {
		if(collider == null && touch == true && forceAction != true) {
			touch = false;
			sendTo.BroadcastMessage("UnTouch");
		}
	}
	void OnTriggerEnter(Collider c) {
		//Debug.Log("FUCK in trig");
		if (c.gameObject.tag == tag) {
			collider = c;
			sendTo.BroadcastMessage("Touch");
			touch = true;
		}
	}
	void OnTriggerExit(Collider c) {
		//Debug.Log("FUCK out trig");
		if (c.gameObject.tag == tag) {
			touch = false;
			sendTo.BroadcastMessage("UnTouch");
		}
	}
}
