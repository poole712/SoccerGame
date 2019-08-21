using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    public Text blueScore;
    public Text greenScore;

    // Start is called before the first frame update
    void Start()
    {
        blueScore.text = "0";
        greenScore.text = "0";
    }
       
    public void UpdateScore(int blueScore0, int greenScore0)
    {
        blueScore.text = blueScore0.ToString();
        greenScore.text = greenScore0.ToString();
    }
}
