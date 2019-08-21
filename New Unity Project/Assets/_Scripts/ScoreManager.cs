using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{


    public int blue;
    public int green;

    private UiManager uiMan;

    private void Start()
    {
        uiMan = GetComponent<UiManager>();
    }

    public void blueScored()
    {
        blue += 1;
        uiMan.UpdateScore(blue, green);
    }

    public void greenScored()
    {

        green += 1;
        uiMan.UpdateScore(blue, green);

    }
}
