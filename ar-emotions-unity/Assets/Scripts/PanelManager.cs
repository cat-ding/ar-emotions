using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelManager : MonoBehaviour
{
    public GameObject hide_button;
    public GameObject show_button;
    public GameObject senario_button;
    public GameObject senario_panel;
    public GameObject scroll;

	public void HidePanel()
	{
        hide_button.SetActive(false);
        scroll.SetActive(false);
        senario_button.SetActive(false);
        senario_panel.SetActive(false);
        show_button.SetActive(true);
	}

    public void ShowPanel()
    {
        show_button.SetActive(false);
        senario_button.SetActive(true);
        scroll.SetActive(true);
        hide_button.SetActive(true);
    }

    public void ShowSenario()
    {
        if (senario_panel.activeSelf)
            senario_panel.SetActive(false);
        else
            senario_panel.SetActive(true);
    }
}
