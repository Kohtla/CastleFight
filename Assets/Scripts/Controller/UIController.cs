using UnityEngine;
using System.Collections;


public class UIController : CFElement
{
    public void TryToBuild(string typeOfBuilding)
    {
        app.model.selectedBuilding = typeOfBuilding;
        Debug.Log(typeOfBuilding);
    }

    
}
