using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour {
	public float sx;
	public float sy;
	public float sz;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (sx, sy, sz);
		
	}
}
