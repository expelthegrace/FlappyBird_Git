using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scrollRanking : MonoBehaviour {

    struct entrada
    {
        public string nom;
        public int score;

        public entrada(string nom, int score)
        {
            this.nom = nom;
            this.score = score;
        }
    }

    public Text rankingT;
    private List<entrada> entrades;

	// Use this for initialization
	void Start () {
        entrades = new List<entrada>();
        rankingT.text = "";
        for (int i = 0; i < 100; ++i)
        {
            entrada entr = new entrada("PlayerName", 9999 );
            rankingT.text = rankingT.text + (i+1).ToString() + ": " + entr.nom + " - " + entr. score + "\n";
        }

        
	}
	
    void listToString()
    {
        rankingT.text = "";
        for (int i = 0; i < entrades.Count; ++i) rankingT.text = rankingT.text + (i+1).ToString() + entrades[i].nom + " - " + entrades[i].score + "\n";
    }

	// Update is called once per frame
	void Update () {
		
	}
}
