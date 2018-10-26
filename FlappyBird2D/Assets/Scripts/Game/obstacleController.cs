using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacleController : MonoBehaviour {

    public GameObject obs1, obs2, obs3, obs4, obs5;
    private GameObject obsA, obsB, obsC, obsD, obsE;

    public float gap;

    public float variabilitat;

    public GameObject limitEsq;

    public bool inici;

	// Use this for initialization
	void Start () {
        gap = 4.45f;
        variabilitat = 3f;

        inici = false;

        obsA = obs1;
        obsB = obs2;
        obsC = obs3;
        obsD = obs4;
        obsE = obs5;

    }

    public void Inici()
    {
        obsA.transform.position = new Vector3(transform.position.x + gap*2, obsA.transform.position.y, obsA.transform.position.z);
        obsB.transform.position = obsA.transform.position + new Vector3(gap, getNextY(obsA), 0);
        obsC.transform.position = obsB.transform.position + new Vector3(gap, getNextY(obsB), 0);
        obsD.transform.position = obsC.transform.position + new Vector3(gap, getNextY(obsC), 0);
        obsE.transform.position = obsD.transform.position + new Vector3(gap, getNextY(obsD), 0);


        inici = true;

    }

    public void Reset()
    {
        obsA.transform.position = obsB.transform.position = obsC.transform.position = new Vector3(-30, 0, 0);
        inici = false;
    }
    // Update is called once per frame
    void Update () {

        if (inici)
        {
            if (obsA.transform.position.x < limitEsq.transform.position.x)
            {
                float nextY = getNextY(obsE);
                GameObject aux = obsA;
                obsA.transform.position = obsE.transform.position + new Vector3(gap, nextY, 0);
                obsA = obsB;
                obsB = obsC;
                obsC = obsD;
                obsD = obsE;
                obsE = aux;
            }
        }
	}

    // obstacle anterior com argument
    float getNextY(GameObject ant)
    {
        return Mathf.Min(Mathf.Max(Random.Range(-variabilitat, variabilitat) + ant.transform.position.y, -1.26f), 2.24f) - ant.transform.position.y;
    }
}
