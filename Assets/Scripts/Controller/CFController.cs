using UnityEngine;
using System.Collections;
using thelab.mvc;

public class CFController : Controller<CFApplication>
{
    public UIController ui { get { return m_ui = Assert<UIController>(m_ui); } }
    private UIController m_ui;

    public MapController map { get { return m_map = Assert<MapController>(m_map); } }
    private MapController m_map;
    // Use this for initialization    
}
