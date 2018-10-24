using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    private bola Bola;
    private obstacleController obstacles;
    private cameraMove cameraMain;
    private background back;

    private bool running, final;

    public GameObject deadCanvas;


	// Use this for initialization
	void Start () {
        Bola = GameObject.Find("Bola").GetComponent<bola>();
        obstacles = GameObject.Find("ObstacleController").GetComponent<obstacleController>();
        cameraMain = GameObject.Find("MainCamera").GetComponent<cameraMove>();
        back = GameObject.Find("BackgroundController").GetComponent<background>();

        deadCanvas.SetActive(false);

        final = false;
        running = false;
	}
	
    void Reset()
    {
        running = false;
        cameraMain.move = true;
        back.move = true;
        Bola.Reset();
        obstacles.Reset();
        final = false;
        deadCanvas.SetActive(false);

    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !running)
        {
            Bola.viu = true;
            obstacles.Inici();
            running = true;
            cameraMain.move = true;
            back.move = true;
        }

        if (!Bola.viu && running && !final) // si el player mor
        {
            deadCanvas.SetActive(true);
            final = true;
            obstacles.inici = false;
            cameraMain.move = false;
            back.move = false;
        }
	}

    public void deadButtons(int x)
    {
        switch (x)
        {
            case 0: //retry
                Reset();
                break;
            case 1: //retry
                SceneManager.LoadScene(0);
                break;
        }
    }
}
