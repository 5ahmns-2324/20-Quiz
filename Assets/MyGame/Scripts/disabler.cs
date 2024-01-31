using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Disabler : MonoBehaviour
{
    public GameObject rightAnswer;
    public GameObject wrongAnswer1;
    public GameObject wrongAnswer2;
    public GameObject nextButton;


    // Start is called before the first frame update
    void Start()
    {
        nextButton.GetComponent<Button>().interactable = false;
    }


    public void ClickAnswer()
    {
        rightAnswer.GetComponent<Button>().interactable = false;
        rightAnswer.GetComponent<Image>().color = Color.green;
        wrongAnswer1.GetComponent<Button>().interactable = false;
        wrongAnswer1.GetComponent<Image>().color = Color.red;
        wrongAnswer2.GetComponent<Button>().interactable = false;
        wrongAnswer2.GetComponent<Image>().color = Color.red;
        nextButton.GetComponent<Button>().interactable = true;

    }

}
