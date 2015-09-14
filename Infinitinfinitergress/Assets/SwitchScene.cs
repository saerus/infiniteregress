using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	int i=0;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")) {
			i = Application.loadedLevel+1;
			if(i>3) {
				i=0;
			}
			Application.LoadLevel(i);
		}
	}
}
