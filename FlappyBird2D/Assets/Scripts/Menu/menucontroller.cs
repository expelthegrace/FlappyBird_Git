using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontroller : MonoBehaviour {

    public GameObject mainPage;
    public GameObject rankingPage;
    public GameObject optionsPage;   

    // Use this for initialization
    void Start () {
        mainPage.SetActive(false);
        rankingPage.SetActive(true);
        optionsPage.SetActive(false);


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
        }

    }

}
