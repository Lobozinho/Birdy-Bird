using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardList : LoboMonoBehaviour
{
    [SerializeField] private List<Text> _texts;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLeaderTexts();
    }

    void LoadLeaderTexts()
    {
        if (this._texts.Count > 0) return;

        foreach(Transform topText in transform)
        {
            this._texts.Add(topText.GetComponentInChildren<Text>());
        }
    }

    void Start()
    {
        for(int i = 0; i < this._texts.Count; i++) 
        {
            int score = ManagersCtrl.Instance.PlayerPrefsManager.TopScore[i];
            this._texts[i].text = score.ToString();
        }
    }

}
