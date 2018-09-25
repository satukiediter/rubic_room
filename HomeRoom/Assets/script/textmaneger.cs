using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textmaneger : MonoBehaviour
{
    GameObject Text;
    GameObject gamane;
    public int count;
    public int ck;
    // Use this for initialization
    void Start()
    {
        Text = GameObject.Find("text");
        gamane = GameObject.Find("Gamedirector");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text.GetComponent<TextMesh>().text = string.Format("{0}回目", count);
        /*ck = gamane.GetComponent<gamemaneger>().cheack;
        if (ck != 0)
        {
            
        }
        else
        {
            Text.GetComponent<TextMesh>().text = string.Format("{0}回目"+"\n"+"クリア！", count);
        }*/
    }
}
