using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Punkte : MonoBehaviour
{
    public int points = 0;
    public TMP_Text pointsText;
    public void Addpoint()
    {
        points++;
    }
    public void Update()
    {
     pointsText.SetText ("Du hast " + points + "/5 Fragen richtig");
    }

}
