using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFElement : MonoBehaviour
{
    // Gives access to the application and all instances.
    public CFApplication app { get { return GameObject.FindObjectOfType<CFApplication>(); } }
}

// 10 Bounces Entry Point.
public class CFApplication : MonoBehaviour
{
    // Reference to the root instances of the MVC.
    public CFModel model;
    public CFView view;
    public CFController controller;

    // Init things here
    void Start() { }
}
