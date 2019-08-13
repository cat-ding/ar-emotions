using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostQuizManager : MonoBehaviour
{
    public TextMeshProUGUI result_text;
    public static int correct;

    public GameObject review_button;

    private void Update()
    {
        result_text.SetText("You got " + correct + " out of 9 correct!");

        if (correct == 9)
        {
            review_button.SetActive(false);
        }
        else
            review_button.SetActive(true);

    }
}
