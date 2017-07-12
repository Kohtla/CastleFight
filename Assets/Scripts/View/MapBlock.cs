using UnityEngine;
using System.Collections;
using thelab.mvc;

public class MapBlock : View<CFApplication>
{    // Update is called once per frame
    public GameObject spawn;
    Transform parent;

    private void Start()
    {
        parent = this.transform;
    }

    private void OnMouseDown()
    {
        
        if (app.model.SelectedBuilding != "")
        {
            Instantiate(spawn, parent.position, Quaternion.identity);
            app.controller.map.Build();
        }
    }
}
