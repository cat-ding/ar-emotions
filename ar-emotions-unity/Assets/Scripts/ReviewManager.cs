using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReviewManager : MonoBehaviour
{
    public static List<string> correct = new List<string>();
    public static List<string> answer = new List<string>();

    public Text answer_counter;
    //public GameObject next_button;

    //THE VIDEOS TO CHECK IF THEY ARE ACTIVE
    public GameObject angry_vid;
    public GameObject doubtful_vid;
    public GameObject content_vid;
    public GameObject disgusted_vid;
    public GameObject distressed_vid;
    public GameObject elated_vid;
    public GameObject happy_vid;
    public GameObject inquisitive_vid;
    public GameObject pensive_vid;

    //EXPLANATIONS
    public GameObject angry_ex;
    public GameObject doubtful_ex;
    public GameObject content_ex;
    public GameObject disgusted_ex;
    public GameObject distressed_ex;
    public GameObject elated_ex;
    public GameObject happy_ex;
    public GameObject inquisitive_ex;
    public GameObject pensive_ex;


    //THE "YOUR ANSWER" IMAGES AND TEXT
    public GameObject angry_wrong;
    public GameObject doubtful_wrong;
    public GameObject content_wrong;
    public GameObject disgusted_wrong;
    public GameObject distressed_wrong;
    public GameObject elated_wrong;
    public GameObject happy_wrong;
    public GameObject inquisitive_wrong;
    public GameObject pensive_wrong;

    public GameObject devastated_wrong;
    public GameObject thoughtful_wrong;
    public GameObject terrified_wrong;
    public GameObject anxious_wrong;
    public GameObject spiteful_wrong;
    public GameObject mean_wrong;
    public GameObject sad_wrong;
    public GameObject scared_wrong;
    public GameObject calm_wrong;
    public GameObject annoyed_wrong;


    //THE "CORRECT ANSWER" IMAGES AND TEXT
    public GameObject angry_correct;
    public GameObject doubtful_correct;
    public GameObject content_correct;
    public GameObject disgusted_correct;
    public GameObject distressed_correct;
    public GameObject elated_correct;
    public GameObject happy_correct;
    public GameObject inquisitive_correct;
    public GameObject pensive_correct;

    //STUFF TO STORE GAMEOBJECTS there are too many :(
    static List<GameObject> videos = new List<GameObject>();
    //static List<GameObject> wrong_ans_list = new List<GameObject>();
    //static List<GameObject> correct_ans_list = new List<GameObject>();

    //FOR THE FOR LOOPS
    private GameObject the_obj;

    //OTHER STUFF
    static GameObject active;
    static int wrong_ans_counter;
    static int size;
    static int count;
    static string str_correct_ans;
    static string str_wrong_ans;

    //INITIALIZE
    private void Start()
    {
        ////adding things to lists
        //wrong_ans_list.Add(happy_wrong);
        //wrong_ans_list.Add(sad_wrong);
        //wrong_ans_list.Add(angry_wrong);
        //wrong_ans_list.Add(confused_wrong);
        //correct_ans_list.Add(happy_correct);
        //correct_ans_list.Add(sad_correct);
        //correct_ans_list.Add(angry_correct);
        //correct_ans_list.Add(confused_correct);
        videos.Add(angry_vid);
        videos.Add(doubtful_vid);
        videos.Add(content_vid);
        videos.Add(disgusted_vid);
        videos.Add(distressed_vid);
        videos.Add(elated_vid);
        videos.Add(happy_vid);
        videos.Add(inquisitive_vid);
        videos.Add(pensive_vid);


        //Debug.Log("START LISTING THE STUFF IN WRONG ANS LIST");
        //for (int i = 0; i < wrong_ans_list.Count; i++)
        //{
        //    Debug.Log(wrong_ans_list[i]);
        //}
        //Debug.Log("END LISTING");

        //Debug.Log("START LISTING THE STUFF IN CORRECT ANS LIST");
        //for (int i = 0; i < correct_ans_list.Count; i++)
        //{
        //    Debug.Log(correct_ans_list[i]);
        //}
        //Debug.Log("END LISTING");

        size = correct.Count;
        //DEBUG STATEMENTS
        for (int i = 0; i < size; i++)
        {
            Debug.Log(correct[i]);
            Debug.Log(answer[i]);
        }
        wrong_ans_counter = 1;
        count = size;

        Display();
    }

    //NNNEXXTTTT
    public void Next()
    {
        answer_counter.text = "Wrong Answer " + wrong_ans_counter + " of " + size;

        Display();
    }

    private void Display()
    {
        str_wrong_ans = answer[count - 1];
        str_correct_ans = correct[count - 1];

        //UPDATE TEXT
        answer_counter.text = "Wrong Answer " + wrong_ans_counter + " of " + size;

        //DISPLAY CORRECT VIDEO AND CORRECT ANSWER IMAGE
        if (str_correct_ans == "angry")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(true);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(true);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(true);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "doubtful")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(true);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(true);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(true);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "content")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(true);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(true);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(true);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "disgusted")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(true);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(true);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(true);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "distressed")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(true);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(true);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(true);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "elated")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(true);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(true);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(true);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "happy")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(true);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(true);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(true);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "inquisitive")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(true);
            pensive_vid.SetActive(false);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(true);
            pensive_ex.SetActive(false);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(true);
            pensive_correct.SetActive(false);
        }
        else if (str_correct_ans == "pensive")
        {
            //TO PLAY VIDEO
            angry_vid.SetActive(false);
            doubtful_vid.SetActive(false);
            content_vid.SetActive(false);
            disgusted_vid.SetActive(false);
            distressed_vid.SetActive(false);
            elated_vid.SetActive(false);
            happy_vid.SetActive(false);
            inquisitive_vid.SetActive(false);
            pensive_vid.SetActive(true);

            angry_ex.SetActive(false);
            doubtful_ex.SetActive(false);
            content_ex.SetActive(false);
            disgusted_ex.SetActive(false);
            distressed_ex.SetActive(false);
            elated_ex.SetActive(false);
            happy_ex.SetActive(false);
            inquisitive_ex.SetActive(false);
            pensive_ex.SetActive(true);

            ////TO DISPLAY IMAGE AND TEXT
            angry_correct.SetActive(false);
            doubtful_correct.SetActive(false);
            content_correct.SetActive(false);
            disgusted_correct.SetActive(false);
            distressed_correct.SetActive(false);
            elated_correct.SetActive(false);
            happy_correct.SetActive(false);
            inquisitive_correct.SetActive(false);
            pensive_correct.SetActive(true);
        }


        //TO DISPLAY WRONG ANSWER IMAGE AND TEXT
        if (str_wrong_ans == "angry")
        {
            elated_wrong.SetActive(false);
            angry_wrong.SetActive(true);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "doubtful")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(true);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "content")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(true);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "disgusted")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(true);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "distressed")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(true);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "elated")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(true);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "happy")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(true);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "inquisitive")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(true);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "pensive")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(true);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "devastated")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(true);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "thoughtful")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(true);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "terrified")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(true);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "anxious")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(true);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "spiteful")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(true);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "mean")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(true);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "sad")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(true);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "scared")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(true);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "calm")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(true);
            annoyed_wrong.SetActive(false);
        }
        else if (str_wrong_ans == "annoyed")
        {
            angry_wrong.SetActive(false);
            doubtful_wrong.SetActive(false);
            content_wrong.SetActive(false);
            disgusted_wrong.SetActive(false);
            distressed_wrong.SetActive(false);
            elated_wrong.SetActive(false);
            happy_wrong.SetActive(false);
            inquisitive_wrong.SetActive(false);
            pensive_wrong.SetActive(false);

            devastated_wrong.SetActive(false);
            thoughtful_wrong.SetActive(false);
            terrified_wrong.SetActive(false);
            anxious_wrong.SetActive(false);
            spiteful_wrong.SetActive(false);
            mean_wrong.SetActive(false);
            sad_wrong.SetActive(false);
            scared_wrong.SetActive(false);
            calm_wrong.SetActive(false);
            annoyed_wrong.SetActive(true);
        }

        //MAYBE ACCOUNT FOR IF THE COUNT == 1 THEN REMOVE THE NEXT BUTTON???
        wrong_ans_counter++;
        count--;
        if (count == 0)
        {
            count = size;
            wrong_ans_counter = 1;
        }
    }

    public static void AddVideo(string video)
    {
        correct.Add(video);
    }

    public static void AddAnswer(string the_answer)
    {
        answer.Add(the_answer);
    }

    public static void ClearWrong()
    {
        correct.Clear();
    }

    public static void ClearAnswers()
    {
        answer.Clear();
    }
}
