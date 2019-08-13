using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationManager : MonoBehaviour
{
    public GameObject explanation_button;
    public GameObject explanation_panel;

    public void ShowExplanation()
    {
        if (explanation_panel.activeSelf)
            explanation_panel.SetActive(false);
        else
            explanation_panel.SetActive(true);
    }
}
