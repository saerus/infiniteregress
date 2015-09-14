using UnityEngine;
using System.Collections;

public class PlateDup : MonoBehaviour {
	public GameObject toDup;
	Vector3 pos = new Vector3();
	public Transform parent;
	float tempDst;
	int nbr = 10;
	float dst = 0.25f;
	GameObject temp;
	// Use this for initialization
	void Start () {
		for(int y=-nbr; y<=nbr; y++) {
			for(int x=-nbr; x<=nbr; x++) {
				pos.x = x*dst;
				pos.y = y*dst;
				temp = GameObject.Instantiate(toDup, toDup.transform.position, toDup.transform.rotation) as GameObject;
				temp.transform.parent = parent;
				temp.transform.Translate(pos);
				tempDst = Mathf.Abs(x)+Mathf.Abs(y)/1f;
				temp.BroadcastMessage("SetFar", tempDst);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
