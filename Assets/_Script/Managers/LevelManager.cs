using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int _scoreLevel = 10;
    [SerializeField] private int _gameLevel = 1;
    public int GameLevel => _gameLevel;

    private void FixedUpdate()
    {
        this.UpdateGameLevel();
    }

    void UpdateGameLevel()
    {
        int score = ManagersCtrl.Instance.ScoreManager.Score;
        if (score < this._scoreLevel) return;
        this._gameLevel++;
        this._scoreLevel *= 2;
    }

}
