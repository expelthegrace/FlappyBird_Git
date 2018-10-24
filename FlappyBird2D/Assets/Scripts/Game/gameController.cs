using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    private bola Bola;
    private obstacleController obstacles;

    private bool inici;

	// Use this for initialization
	void Start () {
        Bola = GameObject.Find("Bola").GetComponent<bola>();
        obstacles = GameObject.Find("ObstacleController").GetComponent<obstacleController>();

        inici = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !inici)
        {
            Bola.viu = true;
            obstacles.Inici();
            inici = true;
        }
	}
}
