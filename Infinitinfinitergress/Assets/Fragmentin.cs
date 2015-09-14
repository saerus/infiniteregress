using UnityEngine;
using System.Collections;

public class Fragmentin : MonoBehaviour {
	Mesh mesh;
	Vector3[] vertices;
	Vector3[] verticesRef;
	Vector3[] verticesRand;
	float[] verticesTime;
	Vector3[] verticesNoise;
	bool[] verticesIn;
	public float force = 1;
	float exp = 0;
	bool touch = false;
	float xr, yr, zr;
	float time = Random.Range(0, 1000);
	Vector3 mult = new Vector3();
	Collider collider;
	Vector3 testPoint;
	// Use this for initialization
	void Start () {
		GameObject thisOne;
		thisOne = this.gameObject;
		mesh = thisOne.GetComponent<MeshFilter>().mesh;
		vertices = mesh.vertices;
		verticesRef = mesh.vertices;
		verticesNoise = new Vector3[mesh.vertices.Length];
		verticesRand = new Vector3[mesh.vertices.Length];
		verticesTime = new float[mesh.vertices.Length];
		verticesIn = new bool[mesh.vertices.Length];
		//
		for(int i=0; i<verticesNoise.Length; i++) {
			xr = Random.Range(-force, force);
			yr = Random.Range(-force, force);
			zr = Random.Range(-force, force);
			verticesRand[i] = new Vector3(xr, yr, zr);
			//
			verticesTime[i] = Random.Range(0, 1000);
		}
	}
	// Update is called once per frame
	void Update () {
		if(touch) {
			for(int i=0; i<verticesRef.Length; i++) {
				testPoint = transform.TransformPoint(verticesRef[i]);
				if(collider.bounds.Contains(testPoint)) {
					verticesIn[i] = true;
				} else {
					verticesIn[i] = false;
				}
			}
		}
		if(touch && exp<1) {
			exp += (1-exp)/10f;
		} else if(!touch && exp>0) {
			exp += (0-exp)/10f;
		}
		// perlin
		time+=1f;
		for(int i=0; i<verticesNoise.Length; i++) {
			verticesTime[i]+=1f;
			xr = Mathf.PerlinNoise(vertices[i].x/100f, verticesTime[i]/100f);
			yr = Mathf.PerlinNoise(vertices[i].y/100f, verticesTime[i]/100f);
			zr = Mathf.PerlinNoise(vertices[i].z/100f, verticesTime[i]/100f);
			verticesNoise[i] = new Vector3(xr, yr, zr);
		}
		for(int i=0; i<vertices.Length; i++) {
			mult.x = verticesRef[i].x+verticesNoise[i].x*verticesRand[i].x*exp;
			mult.y = verticesRef[i].y+verticesNoise[i].y*verticesRand[i].y*exp;
			mult.z = verticesRef[i].z+verticesNoise[i].z*verticesRand[i].z*exp;
			if(verticesIn[i]) {
				vertices[i] = mult;
			} else {
				vertices[i] = verticesRef[i];
			}
		}
		//
		mesh.vertices = vertices;
		mesh.RecalculateNormals();
		mesh.RecalculateBounds();
	}
	void OnColliderEnter() {
		//Debug.Log("FUCK in");
	}
	void OnColliderExit() {
		//Debug.Log("FUCK out");
	}
	void OnTriggerEnter(Collider c) {
		//Debug.Log("FUCK in trig");
		collider = c;
		touch = true;
	}
	void OnTriggerExit() {
		//Debug.Log("FUCK out trig");
		touch = false;
	}
}
