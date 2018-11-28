using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManeger : MonoBehaviour {

    public Material c;
    public Vector3 pos;

    public void ChengeColor(GameObject obj)
    {
        Material mt = obj.GetComponent<Renderer>().material;
        obj.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material;
        this.GetComponent<Renderer>().material = mt;

    }
	// Use this for initialization
	void Start () {
        c = this.GetComponent<Renderer>().material;
        pos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
