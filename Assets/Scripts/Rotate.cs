using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 rotate_amount = new Vector3(24, 55, 35);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotate_amount * Time.deltaTime);
	}
}
