using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CFInterface : CFElement
{
    public Button chooser;
    public Text current;
    // Use this for initialization
    void Start()
    {
        Button btn = chooser.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        if (app.model.selectedBuilding != "")
        {
            current.text = "Выберите место для постройки" + app.model.selectedBuilding;
        }
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        app.controller.ui.TryToBuild(chooser.name);
    }

    private void Update()
    {
        
    }

}
