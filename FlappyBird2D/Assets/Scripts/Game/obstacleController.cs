using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacleController : MonoBehaviour {

    public GameObject obs1, obs2, obs3;
    private GameObject obsA, obsB, obsC;

    public float gap;

    public float variabilitat;

    public GameObject limitEsq;

    private List<GameObject> obstacles;

	// Use this for initialization
	void Start () {
        gap = 4.45f;
        variabilitat = 1f;
        obstacles = new List<GameObject>();

        obstacles.Add(obs1);
        obstacles.Add(obs2);
        obstacles.Add(obs3);

        obsA = obs1;
        obsB = obs2;
        obsC = obs3;

        obsA.transform.position = new Vector3(transform.position.x, obsA.transform.position.y, obsA.transform.position.z);
        obsB.transform.position = obsA.transform.position + new Vector3(gap, Random.Range(-variabilitat,variabilitat), 0);
        obsC.transform.position = obsB.transform.position + new Vector3(gap, Random.Range(-variabilitat, variabilitat), 0);

    }

    // Update is called once per frame
    void Update () {

        if (obsA.transform.position.x < limitEsq.transform.position.x)
        {
            float nextY = Random.Range(-variabilitat, variabilitat);
            GameObject aux = obsA;
            obsA.transform.position = obsC.transform.position + new Vector3(gap, nextY, 0);
            obsA = obsB;
            obsB = obsC;
            obsC = aux;
      
        }
   
	}
}
