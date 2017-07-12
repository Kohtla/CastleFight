using UnityEngine;
using UnityEditor;
using thelab.mvc;

public class CFView : View<CFApplication>
{
    public CFInterface ui { get { return m_ui = Assert<CFInterface>(m_ui); } }
    public CFInterface m_ui;
}