using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

    public float speed;
    public GameObject back1;
    public GameObject back2;
    public GameObject limitEsquerra;

    GameObject tileDisponible;
    GameObject tileEnPantalla;

    public bool move;

    public float backSpeed;


	// Use this for initialization
	void Start () {
        speed = 1;
        backSpeed = 0.25f;
        move = true;
        back1.transform.position = new Vector3(transform.position.x, back1.transform.position.y, back1.transform.position.z);
        back2.transform.position = back1.transform.position + new Vector3(back1.GetComponent<Collider2D>().bounds.size.x, 0, 0);
        tileEnPantalla = back1;
        tileDisponible = back2;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (move)
        {
            tileEnPantalla.transform.position += new Vector3(backSpeed, 0, 0) * Time.deltaTime;
            tileDisponible.transform.position += new Vector3(backSpeed, 0, 0) * Time.deltaTime;
        }

        if (tileEnPantalla.transform.position.x + tileEnPantalla.GetComponent<Collider2D>().bounds.size.x/2 < limitEsquerra.transform.position.x) {
            tileEnPantalla.transform.position = tileDisponible.transform.position + new Vector3(tileEnPantalla.GetComponent<Collider2D>().bounds.size.x, 0, 0);
            GameObject aux = tileEnPantalla;
            tileEnPantalla = tileDisponible;
            tileDisponible = aux;
        }

      

	}
}
