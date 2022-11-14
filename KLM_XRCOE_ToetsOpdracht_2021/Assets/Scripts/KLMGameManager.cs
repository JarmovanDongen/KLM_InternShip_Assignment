using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLMGameManager : MonoBehaviour
{
    public List<GameObject> hangars = new List<GameObject>();
    public List<AIController> aircrafts = new List<AIController>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hangars.Count; i++)
        {
            hangars[i].name += (i + 1).ToString();
            aircrafts[i].name += (i + 1).ToString();
            aircrafts[i].SetHangar(hangars[i].transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Send aircrafts to corresponding hangars
    public void GoToHangar()
    {
        for (int i = 0; i < aircrafts.Count; i++)
        {
            aircrafts[i].GoToHangar();
        }
    }

    //Turn lights on for aircrafts
    public void TurnOnLight()
    {
        for (int i = 0; i < aircrafts.Count; i++)
        {
            aircrafts[i].TurnLightsOn();
        }
    }
}
