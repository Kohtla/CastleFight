using UnityEngine;
using System.Collections;
using thelab.mvc;

public class UIController : Controller<CFApplication>
{
    public void TryToBuild(string typeOfBuilding)
    {
        app.model.SelectedBuilding = typeOfBuilding;
        Debug.Log(typeOfBuilding);
    }

    
}
