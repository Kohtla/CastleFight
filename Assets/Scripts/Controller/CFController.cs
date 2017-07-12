using UnityEngine;
using System.Collections;
using thelab.mvc;

public class CFController : Controller<CFApplication>
{
    public UIController ui { get { return m_ui = Assert<UIController>(m_ui); } }
    private UIController m_ui;
    // Use this for initialization    
}
