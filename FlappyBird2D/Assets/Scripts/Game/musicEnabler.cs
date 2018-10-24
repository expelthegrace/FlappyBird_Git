using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicEnabler : MonoBehaviour {

    private memoria mem;

	// Use this for initialization
	void Start () {
        mem = GameObject.Find("Memoria").GetComponent<memoria>();

        if (mem.musicaon) GetComponent<AudioSource>().Play();
	}
	
}
