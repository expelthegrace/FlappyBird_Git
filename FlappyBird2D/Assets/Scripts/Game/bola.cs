using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour {

    public float gForce;
    public float jumpForce;
    public float fallVel;
    public float jumpVel;

    public bool jumping;

    public GameObject limitInf;
    public bool viu;

	// Use this for initialization
	void Start () {
        gForce = 0.01f;
        jumpForce = 0.2f;

        jumpVel = 0f;
        fallVel = 0f;
        jumping = false;
        viu = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (viu) {
            if (!jumping)
            {
                fallVel += gForce;
                transform.position -= new Vector3(0, fallVel, 0) * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumping = true;
                jumpVel = jumpForce;
                fallVel = 0f;
            }

            if (jumping)
            {
                transform.position += new Vector3(0, jumpVel, 0) * Time.deltaTime;
                jumpVel -= gForce;

                if (jumpVel < 0)
                {
                    jumping = false;
                    fallVel = 0;
                }
            }

            if (transform.position.y < limitInf.transform.position.y) viu = false;
        }
    }
}
