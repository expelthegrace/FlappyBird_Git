using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour {

    public GameObject mainPage;
    public GameObject rankingPage;
    public GameObject optionsPage;
    private memoria mem;
    public Text musicBtext;
    public GameObject music;

    // Use this for initialization
    void Start () {
        mem = GameObject.Find("Memoria").GetComponent<memoria>();
        if (mem == null) Debug.Log("Memoria no assignada");

        mainPage.SetActive(true);
        rankingPage.SetActive(false);
        optionsPage.SetActive(false);

        if (mem.musicaon)
        {
            musicBtext.text = "ON";
            music.GetComponent<AudioSource>().Play();
        }
        else musicBtext.text = "OFF";

        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void switchPages(int x)
    {
        switch(x){
            case 0: // main to ranking
                mainPage.SetActive(false);
                rankingPage.SetActive(true);
                break;
            case 1: // ranking back to main
                rankingPage.SetActive(false);
                mainPage.SetActive(true);
                break;
            case 2: // main to options
                optionsPage.SetActive(true);
                mainPage.SetActive(false);
                break;
            case 3: // options back to main
                optionsPage.SetActive(false);
                mainPage.SetActive(true);
                break;
            case 4: //play
                SceneManager.LoadScene(1);
                break;
        }

    }

    public void musicButton()
    {
        if (mem.musicaon)
        {
            musicBtext.text = "OFF";
            mem.musicaon = false;
            music.GetComponent<AudioSource>().Stop();
        }
        else
        {
            musicBtext.text = "ON";
            mem.musicaon = true;
            music.GetComponent<AudioSource>().Play();

        }
    }

}
