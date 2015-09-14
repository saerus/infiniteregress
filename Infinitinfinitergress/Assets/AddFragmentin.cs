using UnityEngine;
using System.Collections;

public class AddFragmentin : MonoBehaviour {
	Collider temp;
	public string tagCollider = "HAND";
	// Use this for initialization
	void Start () {
		foreach (Transform child in transform)
		{
			child.gameObject.AddComponent<FragmentinDestruct>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
