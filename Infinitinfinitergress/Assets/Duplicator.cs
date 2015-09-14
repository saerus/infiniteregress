using UnityEngine;
using System.Collections;

public class Duplicator : MonoBehaviour {
	public GameObject toDup;
	public GameObject toDup2;
	public GameObject toDup3;
	public Transform parent;
	GameObject temp;
	int nbr = 8;
	float r = 1f;
	// Use this for initialization
	void Start () {
		for(int j=-5; j<=5; j++) {
			nbr = 8;
			for(int i=0; i<nbr; i++) {
				temp = Instantiate(toDup, new Vector3(0, -i*3*r+(j*12*r)), Quaternion.Euler(0, 45*i, 0)) as GameObject;
				temp.transform.SetParent(parent, false); 
			}
		}
		for (int j=0; j<1; j++) {
			for (int i=0; i<4; i++) {
				temp = Instantiate (toDup2, new Vector3 (0, j * 12*r, 0), Quaternion.Euler (0, 90 * i, 0)) as GameObject;
				temp.transform.SetParent(parent, false);
			}
		}
		for (int j=0; j<2; j++) {
			for (int i=0; i<4; i++) {
				temp =Instantiate (toDup3, new Vector3 (0, j * 12*r, 0), Quaternion.Euler (0, 90 * i, 0)) as GameObject;
				temp.transform.SetParent(parent, false);
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}