using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using thelab.mvc;

public class CFInterface : View<CFApplication>
{
    public Button chooser;
    public Text current;
    // Use this for initialization
    void Start()
    {
        Button btn = chooser.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
              
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        app.controller.ui.TryToBuild(chooser.name);
        current.text = "Выберите место для постройки " + chooser.name;
    }

    

}
