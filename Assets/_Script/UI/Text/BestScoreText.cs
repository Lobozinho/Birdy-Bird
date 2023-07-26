using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScoreText : BaseText
{
    
    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("Top1", 0);
        this.text.text = bestScore.ToString();
    }

}
