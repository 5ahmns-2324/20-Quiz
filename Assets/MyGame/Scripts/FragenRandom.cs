using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FragenRandom : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject questionBody;
    public int questionNumber = 1;
    public float timer = 15;
    public TMP_Text timeText;
    public GameObject fragencanvis;
    public GameObject vorbeiCanvis;
    public int winPoints;

    public void AddWinner()
    {
        winPoints++;
    }

    void Start()
    {
        Shuffle(questions);
        questionNumber = 1;
        fragencanvis.SetActive(true);
        vorbeiCanvis.SetActive(false);
    }

    public void Shuffle(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            int destIndex = Random.Range(0, gameObjects.Length);
            GameObject source = gameObjects[i];
            GameObject dest = gameObjects[destIndex];
            if (source != dest)
            {
                Vector3 tmp = source.transform.position;
                source.transform.position = dest.transform.position;
                dest.transform.position = tmp;
            }
        }
    }

    public void NextQuestion()
    {
        questionNumber++ ;
        timer = 15;
        Time.timeScale = 1;
    }
    public void Update()
    {
        if (questionNumber == 1)
        {
            questionBody.transform.localPosition = new Vector3(50f, -750f, 0f);
        }
        if (questionNumber == 2)
        {
            questionBody.transform.localPosition = new Vector3(50f, -20f, 0f);
        }
        if (questionNumber == 3)
        {
            questionBody.transform.localPosition = new Vector3(50f, 650f, 0f);
        }
        if (questionNumber == 4)
        {
            questionBody.transform.localPosition = new Vector3(50f, 1350f, 0f);
        }
        if (questionNumber == 5)
        {
            questionBody.transform.localPosition = new Vector3(50f, 2050f, 0f);
        }

        timer -= Time.deltaTime;
        timeText.text = timer.ToString("F0")+"s";


        if (timer <= 0)
        {
            timer = 15;
            NextQuestion();

            winPoints++;
        }

        if (winPoints == 5)
        {
            fragencanvis.SetActive(false);
            vorbeiCanvis.SetActive(true);

        }

    }

    public void StopTime()
    {
        Debug.Log("BRUH");
        Time.timeScale = 0;
    }




}
