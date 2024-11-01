using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour 
{
    TMP_Text text;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }
    
    private void Update()
    {
        text.text = ScoreUpdate.currentScore.ToString();
    }
}