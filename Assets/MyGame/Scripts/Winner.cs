using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Winner : MonoBehaviour
{
    public GameObject fragenCanvis;
    public GameObject endeCanvis;
    

    public int WinPoints;
    public void AddWinner()
    {
        WinPoints++;
    }

    void Start()
    {
        fragenCanvis.SetActive(true);
        endeCanvis.SetActive(false);
        
    }
    
    void Update()
    {
        if (WinPoints == 5)
        {
            fragenCanvis.SetActive(false);
            endeCanvis.SetActive(true);

        }

    }
}
