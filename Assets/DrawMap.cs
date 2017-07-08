using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawMap : MonoBehaviour {
    public GameObject freePart;
    public GameObject closedPart;
    public float x;
    public float z;

    // Use this for initialization
    void Start () {
        LogicMap map = new LogicMap((int)x, (int)z);
        map.TakePosition(5, 4);
        map.TakePosition(7, 8);

        for (int i = 0; i < (int)x; i++)
        {
            for (int j = 0; j < (int)z; j++)
            {
                //Debug.Log(i + ":" + j);
                if (!map.Map[i, j])
                {
                    Instantiate(freePart, new Vector3(i*2, 0, j*2), Quaternion.identity);
                }
                else
                {
                    Instantiate(closedPart, new Vector3(i*2, 0, j*2), Quaternion.identity);
                }
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
