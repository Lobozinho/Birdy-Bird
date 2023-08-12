using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScoreText : BaseText
{

    public static string TOP_1 = "Top1";

    void Start()
    {
        
        int bestScore = PlayerPrefs.GetInt(TOP_1, 0);
        this.text.text = bestScore.ToString();
    }

}
