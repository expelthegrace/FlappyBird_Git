using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacleController : MonoBehaviour {

    public GameObject obs1, obs2, obs3;
    private GameObject obsA, obsB, obsC;

    public float gap;

    public float variabilitat;

    public GameObject limitEsq;

    public bool inici;

    private List<GameObject> obstacles;

	// Use this for initialization
	void Start () {
        gap = 4.45f;
        variabilitat = 3f;
        obstacles = new List<GameObject>();

        obstacles.Add(obs1);
        obstacles.Add(obs2);
        obstacles.Add(obs3);

        inici = false;

        obsA = obs1;
        obsB = obs2;
        obsC = obs3;
       
    }
    public void Inici()
    {
        obsA.transform.position = new Vector3(transform.position.x + gap+2, obsA.transform.position.y, obsA.transform.position.z);
        obsB.transform.position = obsA.transform.position + new Vector3(gap, getNextY(obsA), 0);
        obsC.transform.position = obsB.transform.position + new Vector3(gap, getNextY(obsB), 0);
        inici = true;

    }
    // Update is called once per frame
    void Update () {

        if (inici)
        {
            if (obsA.transform.position.x < limitEsq.transform.position.x)
            {
                float nextY = getNextY(obsC);
                GameObject aux = obsA;
                obsA.transform.position = obsC.transform.position + new Vector3(gap, nextY, 0);
                obsA = obsB;
                obsB = obsC;
                obsC = aux;

            }
        }
	}

    float getNextY(GameObject ant)
    {
        return Mathf.Min(Mathf.Max(Random.Range(-variabilitat, variabilitat) + ant.transform.position.y, -1.26f), 2.24f) - ant.transform.position.y;
    }
}
