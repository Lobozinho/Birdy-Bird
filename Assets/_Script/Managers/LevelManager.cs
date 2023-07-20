using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float _scoreLevel = 10;
    [SerializeField] private float _scoreIndex = 2;
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
        this.LevelUp();
        this._scoreLevel *= this._scoreIndex;
    }

    void LevelUp()
    {
        this._gameLevel++;
        this.UpdateScoreIndex();
        PlayerCtrl.Instance.PlayerMovement.UpdateSpeed();
        SpawnerCtrl.Instance.PipeSpawner.UpdateTimeDelay();
    }

    void UpdateScoreIndex()
    {
        if (this._gameLevel < 7) return;
        this._scoreIndex = 1.5f;
    }

}
