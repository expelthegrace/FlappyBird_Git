using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bola : MonoBehaviour {

    public float gForce;
    public float jumpForce;
    public float fallVel;
    public float jumpVel;

    public bool jumping;

    public GameObject limitInf;
    public bool viu;

    public int score;
    public Text scoreT;

    public AudioSource jumpA;

	// Use this for initialization
	void Start () {
        gForce = 0.85f;
        jumpForce = 13f;

        jumpVel = 0f;
        fallVel = 0f;
        jumping = false;
        viu = false;
        score = 0;
    }
	
    public void Reset()
    {
        jumpVel = 0f;
        fallVel = 0f;
        jumping = false;
        viu = false;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        score = 0;
    }
	// Update is called once per frame
	void Update () {

        scoreT.text = "Score " + score.ToString();

        if (viu) {
            if (!jumping)
            {
                fallVel += gForce;
                transform.position -= new Vector3(0, fallVel, 0) * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpA.Play();
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "death") viu = false;
        else if (col.gameObject.tag == "forat") ++score;
        Debug.Log("colisions");
    }
}
