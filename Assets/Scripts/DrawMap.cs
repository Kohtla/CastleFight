using System.Collections;
using System.Collections.Generic;
using thelab.mvc;
using UnityEngine;

public class DrawMap : View<CFApplication> {
    public GameObject freePart;
    public GameObject closedPart;
    public GameObject parent;
    private GameObject inst;
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
                    inst = Instantiate(freePart, new Vector3(i*2, 0, j*2), Quaternion.identity);
                    inst.transform.parent = parent.transform;
                }
                else
                {
                    inst = Instantiate(closedPart, new Vector3(i*2, 0, j*2), Quaternion.identity);
                    inst.transform.parent = parent.transform;
                }
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
