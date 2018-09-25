using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivotmaneger : MonoBehaviour
{

    [SerializeField]
    GameObject[] obj = new GameObject[9];

    [SerializeField]
    GameObject maincamera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {/*
        var controller = OVRInput.GetActiveController();
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
                if (OVRInput.Get(OVRInput.Button.Up) || OVRInput.Get(OVRInput.Button.Down))
                {
                    if (this.gameObject.name == "centerpivotX1" ||
                        this.gameObject.name == "centerpivotX2" ||
                        this.gameObject.name == "centerpivotX3")
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            obj[i].transform.parent = this.transform;
                        }
                    }
                }
            if (maincamera.transform.rotation.x <= 80 && maincamera.transform.rotation.x >= -80)
            {
                if (OVRInput.Get(OVRInput.Button.Left) || OVRInput.Get(OVRInput.Button.Right))
                {

                    if (this.gameObject.name == "centerpivotY1" ||
                        this.gameObject.name == "centerpivotY2" ||
                        this.gameObject.name == "centerpivotY3")
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            obj[i].transform.parent = this.transform;
                        }
                    }

                }
            }
            else
            {
                if (OVRInput.Get(OVRInput.Button.Left) || OVRInput.Get(OVRInput.Button.Right))
                {

                    if (this.gameObject.name == "centerpivotZ1" ||
                        this.gameObject.name == "centerpivotZ2" ||
                        this.gameObject.name == "centerpivotZ3")
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            obj[i].transform.parent = this.transform;
                        }
                    }

                }
            }
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            for (int i = 0; i < 12; i++)
            {
                obj[i].transform.parent = null;
            }
        }*/
    }
}
