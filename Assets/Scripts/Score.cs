using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 5;
 
    int score;
 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }
   
    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}