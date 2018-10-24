using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scrollRanking : MonoBehaviour {


    
    public struct entrada
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
    public List<entrada> entrades;
    
	// Use this for initialization
	void Start () {
        entrades = new List<entrada>();
        rankingT.text = "";
        for (int i = 0; i < 50; ++i)
        {
            entrada entr = new entrada("PlayerName-" + Random.Range(0,500), Random.Range(0, 500));
            entrades.Add(entr);
           // rankingT.text = rankingT.text + (i+1).ToString() + ": " + entr.nom + " - " + entr. score + "\n";
        }

        orderBy(1); //order by score at beginning
	}
	
    void listToString()
    {
        rankingT.text = "";
        for (int i = 0; i < entrades.Count; ++i) rankingT.text = rankingT.text + (i+1).ToString() + ": " + entrades[i].nom + " - " + entrades[i].score + "\n";
    }


    void orderBy(int x)
    {

        switch(x)
        {
            
            case 0: //order by name
                entrades = entrades.OrderBy(tile => tile.nom).ToList();
                break;
            case 1: //order by name
                entrades = entrades.OrderByDescending(tile => tile.score).ToList();
                break;
        }
        listToString();
    }

    public void orderButtons(int x)
    {
        orderBy(x);
    }
}
