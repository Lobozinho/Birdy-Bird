using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardMenu : LoboMonoBehaviour
{
    [SerializeField] private LeaderBoardList _leaderBoardList;
    public LeaderBoardList LeaderBoardList => _leaderBoardList;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLeaderBoardList();
    }

    void LoadLeaderBoardList()
    {
        if (this._leaderBoardList != null) return;
        this._leaderBoardList = GetComponentInChildren<LeaderBoardList>();
        Debug.LogWarning(transform.name + ": LoadLeaderBoardList", gameObject);
    }

}
