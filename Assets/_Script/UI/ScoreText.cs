using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : BaseText
{
    [Header("Score Text")]
    [SerializeField] private int _score;
    
    private void FixedUpdate()
    {
        this.GetScore();
        this.SetScoreText();
    }

    void GetScore()
    {
        this._score = ManagersCtrl.Instance.ScoreManager.Score;
    }

    void SetScoreText()
    {
        this.text.text = this._score.ToString();
    }

}
