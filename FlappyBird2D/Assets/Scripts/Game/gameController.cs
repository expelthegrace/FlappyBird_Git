using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    private bola Bola;
    private bool inici;

	// Use this for initialization
	void Start () {
        Bola = GameObject.Find("Bola").GetComponent<bola>();
        inici = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
