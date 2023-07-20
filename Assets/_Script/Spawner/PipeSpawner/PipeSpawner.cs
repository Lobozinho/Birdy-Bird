using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : Spawner
{
    [SerializeField] private float _offsetPosition;
    [SerializeField] private float _timer = 0;
    [SerializeField] private float _timeDelay = 8;
    [SerializeField] private float _minTimeDelay = 4;
    [SerializeField] private float _timeLevelUp = 0.3f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this._offsetPosition = Camera.main.orthographicSize * Camera.main.aspect;
    }

    private void FixedUpdate()
    {
        this.PipeSpawning();
    }

    void PipeSpawning()
    {
        if(!this.IsLevelStart()) return;

        this._timer += Time.fixedDeltaTime;
        if (this._timer < this._timeDelay) return;
        this._timer = 0;
        
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, this.GetPos(), transform.rotation);
        obj.gameObject.SetActive(true);
    }

    bool IsLevelStart()
    {
        return ManagersCtrl.Instance.GameManager.LevelStart;
    }

    Vector3 GetPos()
    {
        float playerPosX = PlayerCtrl.Instance.transform.position.x;
        Vector3 pos = new Vector3(playerPosX + this._offsetPosition, this.RamdomPosY(), 0);
        return pos;
    }

    float RamdomPosY()
    {
        int gameLevel = ManagersCtrl.Instance.LevelManager.GameLevel;
        if (gameLevel < 2) return 0;
        float posY = UnityEngine.Random.Range(-2, 1);
        return posY;   
    }

    public void UpdateTimeDelay()
    {
        this._timeDelay -= this._timeLevelUp;
        if(this._timeDelay < this._minTimeDelay) this._timeDelay = this._minTimeDelay;
    }

}
