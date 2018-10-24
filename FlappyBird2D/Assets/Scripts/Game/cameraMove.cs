using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    public float camSpeed;
    public bool move;

	// Use this for initialization
	void Start () {
        camSpeed = 3.2f;
        move = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (move) transform.position += new Vector3(camSpeed, 0, 0) * Time.deltaTime;

	}
}
