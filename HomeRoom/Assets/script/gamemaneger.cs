using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class gamemaneger : MonoBehaviour {

    public GameObject[] cubes1;
    public GameObject[] cubes2;
    public GameObject[] cubes3;
    public GameObject[] cubes4;
    public GameObject[] cubes5;
    public GameObject[] cubes6;
    public int cheack;
    public GameObject line;
    public PlayableDirector playableDirector;

    public int Ck(GameObject[] a)
    {
        int b = 0;
        Material c = a[0].GetComponent<Renderer>().material;
        for (int i = 1; i < 9; i++)
        {
            if (a[i].GetComponent<Renderer>().material == c)
            {
                b++;
            }
        }
        if(b == 9)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public int Ck2()
    {
        int c = 0;
        if (Ck(cubes1) == 1)
        {
            c++;
        }
        if (Ck(cubes2) == 1)
        {
            c++;
        }
        if (Ck(cubes3) == 1)
        {
            c++;
        }
        if (Ck(cubes4) == 1)
        {
            c++;
        }
        if (Ck(cubes5) == 1)
        {
            c++;
        }
        if (Ck(cubes6) == 1)
        {
            c++;
        }
        return 6-c;
    }

    void PlayTimeline()
    {
        playableDirector.Play();
    }

    //一時停止する
    void PauseTimeline()
    {
        playableDirector.Pause();
    }

    //一時停止を再開する
    void ResumeTimeline()
    {
        playableDirector.Resume();
    }

    //停止する
    void StopTimeline()
    {
        playableDirector.Stop();
    }

    // Use this for initialization
    void Start () {
        cubes1 = GameObject.FindGameObjectsWithTag("cube");
        cubes2 = GameObject.FindGameObjectsWithTag("cube1");
        cubes3 = GameObject.FindGameObjectsWithTag("cube2");
        cubes4 = GameObject.FindGameObjectsWithTag("cube3");
        cubes5 = GameObject.FindGameObjectsWithTag("cube4");
        cubes6 = GameObject.FindGameObjectsWithTag("cube5");
        cheack = 6;
        line = GameObject.Find("endline");
        playableDirector = line.GetComponent<PlayableDirector>();

    }
	
	// Update is called once per frame
	void Update () {
        cheack = Ck2();
        if (cheack == 0)
        {
            PlayTimeline();
        }
	}
}
