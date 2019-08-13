using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizManager : MonoBehaviour
{
    //TARGET 1
    public GameObject happy_vid;
    public GameObject content_vid; 
    public GameObject pensive_vid;
    public GameObject angry_vid;
    public GameObject elated_vid;
    public GameObject disgusted_vid;
    public GameObject distressed_vid;
    public GameObject inquisitive_vid;
    public GameObject doubtful_vid;

    public GameObject angry_senario;
    public GameObject doubtful_senario;
    public GameObject content_senario;
    public GameObject disgusted_senario;
    public GameObject distressed_senario;
    public GameObject elated_senario;
    public GameObject happy_senario;
    public GameObject inquisitive_senario;
    public GameObject pensive_senario;


    public Text the_text;

    static int question_counter;
    static int num_correct;
    static int total;
    static int count;
    static GameObject active;
    static string button_pressed; //testinggggggg

    static List<GameObject> list = new List<GameObject>();

    static int rand;

    private void Start()
    {
        question_counter = 1;
        num_correct = 0;
        total = 9;
        count = 9;
        list.Clear();
        ReviewManager.ClearWrong();
        ReviewManager.ClearAnswers();

        //initialize list
        list.Add(angry_vid);
        list.Add(doubtful_vid);
        list.Add(content_vid);
        list.Add(disgusted_vid);
        list.Add(distressed_vid);
        list.Add(elated_vid);
        list.Add(happy_vid);
        list.Add(inquisitive_vid);
        list.Add(pensive_vid);

        //display first random video
        rand = (int)Random.Range(0, count);
        active = list[rand];
        list.RemoveAt(rand);
        active.SetActive(true);
        count--;

        ShowSenario();

        the_text.text = "Question " + question_counter + " of 9";
    }

    //is called when elated button is pressed
    public void ElatedPressed()
    {
        button_pressed = "elated";
        ButtonPressed();
    }

    //is called when angry button is pressed
    public void AngryPressed()
    {
        button_pressed = "angry";
        ButtonPressed();
    }

    //is called when doubtful button is pressed
    public void DoubtfulPressed()
    {
        button_pressed = "doubtful";
        ButtonPressed();
    }

    //is called when negative button is pressed
    public void ContentPressed()
    {
        button_pressed = "content";
        ButtonPressed();
    }

    //is called when disgusted button is pressed
    public void DisgustedPressed()
    {
        button_pressed = "disgusted";
        ButtonPressed();
    }

    //is called when distressed button is pressed
    public void DistressedPressed()
    {
        button_pressed = "distressed";
        ButtonPressed();
    }

    //is called when positive button is pressed
    public void HappyPressed()
    {
        button_pressed = "happy";
        ButtonPressed();
    }

    //is called when inquisitive button is pressed
    public void InquisitivePressed()
    {
        button_pressed = "inquisitive";
        ButtonPressed();
    }

    //is called when random button is pressed
    public void PensivePressed()
    {
        button_pressed = "pensive";
        ButtonPressed();
    }

    public void DevastatedPressed()
    {
        button_pressed = "devastated";
        ButtonPressed();
    }

    public void ThoughtfulPressed()
    {
        button_pressed = "thoughtful";
        ButtonPressed();
    }

    public void TerrifiedPressed()
    {
        button_pressed = "terrified";
        ButtonPressed();
    }

    public void AnxiousPressed()
    {
        button_pressed = "anxious";
        ButtonPressed();
    }

    public void SpitefulPressed()
    {
        button_pressed = "spiteful";
        ButtonPressed();
    }

    public void MeanPressed()
    {
        button_pressed = "mean";
        ButtonPressed();
    }

    public void SadPressed()
    {
        button_pressed = "sad";
        ButtonPressed();
    }

    public void ScaredPressed()
    {
        button_pressed = "scared";
        ButtonPressed();
    }

    public void CalmPressed()
    {
        button_pressed = "calm";
        ButtonPressed();
    }

    public void AnnoyedPressed()
    {
        button_pressed = "annoyed";
        ButtonPressed();
    }

    private void ButtonPressed()
    {
        if (button_pressed == active.name)
        {
            num_correct++;
        }
        else
        {
            ReviewManager.AddVideo(active.name);
            ReviewManager.AddAnswer(button_pressed);
        }

        if (count == 0 || question_counter >= 9)
        {
            PostQuizManager.correct = num_correct;
            quizComplete();
            return;
        }
        else
        {
            question_counter++;
            the_text.text = "Question " + question_counter + " of 9";

            active.SetActive(false);
            rand = (int)Random.Range(0, count);
            active = list[rand];
            list.RemoveAt(rand);
            active.SetActive(true);
            count--;

            ShowSenario();
        }
    }

    private void ShowSenario()
    {
        if (angry_vid.activeSelf)
        {
            angry_senario.SetActive(true);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (doubtful_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(true);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (content_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(true);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (disgusted_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(true);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (distressed_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(true);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (elated_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(true);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (happy_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(true);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(false);
        }
        else if (inquisitive_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(true);
            pensive_senario.SetActive(false);
        }
        else if (pensive_vid.activeSelf)
        {
            angry_senario.SetActive(false);
            doubtful_senario.SetActive(false);
            content_senario.SetActive(false);
            disgusted_senario.SetActive(false);
            distressed_senario.SetActive(false);
            elated_senario.SetActive(false);
            happy_senario.SetActive(false);
            inquisitive_senario.SetActive(false);
            pensive_senario.SetActive(true);
        }
    }

    public void Restart()
    {
        question_counter = 1;
        num_correct = 0;
        count = 9;
        the_text.text = "Question " + question_counter + " of 9";
        list.Clear();
        ReviewManager.ClearWrong();
        ReviewManager.ClearAnswers();

        //initialize list again
        list.Add(angry_vid);
        list.Add(doubtful_vid);
        list.Add(content_vid);
        list.Add(disgusted_vid);
        list.Add(distressed_vid);
        list.Add(elated_vid);
        list.Add(happy_vid);
        list.Add(inquisitive_vid);
        list.Add(pensive_vid);

        //display first random video
        active.SetActive(false);
        rand = (int)Random.Range(0, count);
        active = list[rand];
        list.RemoveAt(rand);
        active.SetActive(true);
        count--;

        ShowSenario();
    }


    private void quizComplete()
    {
        SceneManager.LoadScene("finished");
        return;
    }
}
