using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    public float camSpeed;

	// Use this for initialization
	void Start () {
        camSpeed = 3f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += new Vector3(camSpeed, 0, 0) * Time.deltaTime;

	}
}
