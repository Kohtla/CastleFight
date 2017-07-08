using UnityEngine;
using System.Collections;

public class TestCam : MonoBehaviour {

    public GameObject camRig;
    public float speed = 10;
    public float X=50;
    public float Y=50;
    public float Z=-30;
    Vector3 coords;

	// Use this for initialization
	void Start () 
    {
        camRig.transform.position = new Vector3(X, Y, Z);
        coords = camRig.transform.position;
                        	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (Input.GetKey(KeyCode.W))
        {
            coords.z += speed*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.S))
        {
            coords.z -= speed*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.A))
        {
            coords.x -= speed*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.D))
        {
            coords.x += speed*Time.deltaTime;
            camRig.transform.position = coords;
        }
	
	}
}
