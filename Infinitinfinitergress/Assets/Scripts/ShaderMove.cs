using UnityEngine;
using System.Collections;

public class ShaderMove : MonoBehaviour {
	Renderer rend;
	Vector2 offset = new Vector2();
	float time = 0;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		time++;
		offset.x = Mathf.PerlinNoise(2354, time/1000f);
		offset.y = Mathf.PerlinNoise(1214, time/1000f);
		rend.material.SetTextureOffset("_MainTex", offset);
	}
}
