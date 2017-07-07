using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawMap : MonoBehaviour {
    public GameObject mapPart;
    public float x;
    public float z;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                Instantiate(mapPart, new Vector3(i, 0, j), Quaternion.identity);
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
