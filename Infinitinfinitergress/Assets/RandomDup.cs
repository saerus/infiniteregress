using UnityEngine;
using System.Collections;

public class RandomDup : MonoBehaviour {
	GameObject temp;
	public GameObject toDup;
	Vector3 pos = new Vector3 ();
	float dst;
	float h;
	float a;
	float nbr;
	// Use this for initialization
	void Start () {
		for(int j=2; j<40; j++) {
			nbr = 8+j*8;
			dst = j*0.2f;
			a = (Mathf.PI*2)/nbr;
			for(int i=0; i<nbr; i++) {
				h = 0.8f/j+0.1f;
				if(Random.Range(0f, 1f) < 0.3f) {
					pos.x = Mathf.Cos(i*a)*dst;
					pos.z = Mathf.Sin(i*a)*dst;
					temp = Instantiate(toDup, new Vector3(pos.x, 0, pos.z), Quaternion.identity) as GameObject;
					h+=Random.Range(-0.1f, 0.1f);
					temp.transform.localScale = new Vector3(0.01f, h, 0.01f);
				}
				//temp.transform.SetParent(parent, false); 
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
