using System.Collections;
using System.Collections.Generic;
using thelab.mvc;
using UnityEngine;

public class CFModel : Model<CFApplication> {

    public int material;
    public int energy;
    private string selectedBuilding = "";

    public string SelectedBuilding
    {
        get
        {
            return selectedBuilding;
        }

        set
        {
            selectedBuilding = value;
        }
    }
}
