using UnityEngine;
using UnityEditor;
using thelab.mvc;

public class CFView : View<CFApplication>
{
    public CFInterface ui { get { return m_ui = Assert<CFInterface>(m_ui); } }
    private CFInterface m_ui;

    public DrawMap mapDrawer { get { return m_mapDrawer = Assert<DrawMap>(m_mapDrawer); } }
    private DrawMap m_mapDrawer;
}