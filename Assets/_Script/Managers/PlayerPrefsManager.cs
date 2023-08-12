using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    [SerializeField] private List<int> _topScore;
    public List<int> TopScore => _topScore;

    public static string TOP_1 = "Top1";
    public static string TOP_2 = "Top2";
    public static string TOP_3 = "Top3";
    public static string TOP_4 = "Top4";
    public static string TOP_5 = "Top5";
    public static string TOP_6 = "Top6";
    public static string TOP_7 = "Top7";
    
    public static string BIRD_COUNT = "BirdCount";

    private void Start()
    {
        this.LoadTopScore();
    }

    void LoadTopScore()
    {
        this._topScore.Add(PlayerPrefs.GetInt(TOP_1, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_2, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_3, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_4, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_5, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_6, 0));
        this._topScore.Add(PlayerPrefs.GetInt(TOP_7, 0));
    }

    public void SaveTopScore()
    {
        this._topScore.Add(ManagersCtrl.Instance.ScoreManager.Score);
        this._topScore.Sort((x, y) => y.CompareTo(x));

        PlayerPrefs.SetInt(TOP_1, this._topScore[0]);
        PlayerPrefs.SetInt(TOP_2, this._topScore[1]);
        PlayerPrefs.SetInt(TOP_3, this._topScore[2]);
        PlayerPrefs.SetInt(TOP_4, this._topScore[3]);
        PlayerPrefs.SetInt(TOP_5, this._topScore[4]);
        PlayerPrefs.SetInt(TOP_6, this._topScore[5]);
        PlayerPrefs.SetInt(TOP_7, this._topScore[6]);
    }

    public void SaveBirdCount()
    {
        PlayerPrefs.SetInt(BIRD_COUNT, UICtrl.Instance.BirdSelectMenu.BirdList.BirdCount);
    }

    public int GetBirdCount()
    {
        return PlayerPrefs.GetInt(BIRD_COUNT);
    }

}
