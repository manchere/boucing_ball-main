using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text briqueText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       
        scoreText.text = "SCORE: " + score.ToString() + " POINTS";
    }

    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 10;
        scoreText.text = "SCORE: "+ score.ToString() + " POINTS";
        briqueText.text = "BRIQUES: " + Bonus.CountObject("brique");
    }
}
