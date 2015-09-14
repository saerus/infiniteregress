using UnityEngine;
using System.Collections;

public class DupGen : MonoBehaviour {
	GameObject temp;
	public int nbr = 4;
	public GameObject toDup;
	public Transform parent;
	float angle;
	// Use this for initialization
	void Start () {
		angle = 360f / nbr;
		for (int i=1; i<nbr; i++) {
			temp = Instantiate (toDup, toDup.transform.position, Quaternion.Euler (0, angle * i, 0)) as GameObject;
			temp.transform.SetParent(parent, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
