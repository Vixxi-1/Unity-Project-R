using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
    public GameObject toFollow;
    private Vector3 offset;
    public bool follow_x = true;
    public bool follow_y = false;
    public bool follow_z = false;

	// Use this for initialization
	void Start () {
        offset = transform.position - toFollow.transform.position;
		
	}
	
	// LateUpdate is called once per frame, after Update has been run
	void LateUpdate () {
        Vector3 diff = toFollow.transform.position + offset;
        float x = follow_x ? diff.x : transform.position.x;
        float y = follow_y ? diff.y : transform.position.y;
        float z = follow_z ? diff.z : transform.position.z;
        transform.position = new Vector3(x, y, z);
	}
}
