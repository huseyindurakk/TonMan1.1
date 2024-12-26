using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// responsible to get score n display at the end.

public class DisplayScore : MonoBehaviour
{   int Score;
    public Text txt;
    string scoreT, ScoreT1, ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt(ScoreDisplay, 0); //this will get the score saved in the prefs.
    }

    // Update is called once per frame
    void Update()
    {
        ScoreT1 = Score.ToString();
        scoreT = "Score: " + ScoreT1;
        txt.text = scoreT;
    }
}
