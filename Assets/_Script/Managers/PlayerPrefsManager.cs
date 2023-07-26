using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    [SerializeField] private List<int> _topScore;

    private void Start()
    {
        this.LoadTopScore();
    }

    void LoadTopScore()
    {
        this._topScore.Add(PlayerPrefs.GetInt("Top1", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top2", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top3", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top4", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top5", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top6", 0));
        this._topScore.Add(PlayerPrefs.GetInt("Top7", 0));
    }

    public void SaveTopScore()
    {
        this._topScore.Add(ManagersCtrl.Instance.ScoreManager.Score);
        this._topScore.Sort((x, y) => y.CompareTo(x));

        PlayerPrefs.SetInt("Top1", this._topScore[0]);
        PlayerPrefs.SetInt("Top2", this._topScore[1]);
        PlayerPrefs.SetInt("Top3", this._topScore[2]);
        PlayerPrefs.SetInt("Top4", this._topScore[3]);
        PlayerPrefs.SetInt("Top5", this._topScore[4]);
        PlayerPrefs.SetInt("Top6", this._topScore[5]);
        PlayerPrefs.SetInt("Top7", this._topScore[6]);
    }

}
