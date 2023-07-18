using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    [SerializeField] private bool _isAddScore = false;

    private void OnEnable()
    {
        this._isAddScore = false;
    }

    private void Update()
    {
        this.CheckScore();    
    }

    void CheckScore()
    {
        if (PlayerCtrl.Instance.transform.position.x < transform.position.x) return;
        if (_isAddScore) return;
        ManagersCtrl.Instance.ScoreManager.AddScore();
        this._isAddScore = true;
    }    

}
