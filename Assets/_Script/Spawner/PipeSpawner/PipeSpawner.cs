using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : Spawner
{
    [SerializeField] private float _offsetPosition;
    [SerializeField] private float _timeDelay = 8;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this._offsetPosition = Camera.main.orthographicSize * Camera.main.aspect;
    }

    public void Start()
    {
        InvokeRepeating(nameof(this.PipeSpawning), 0.5f, this._timeDelay);
    }

    void PipeSpawning()
    {
        if(!this.IsLevelStart()) return;
        
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

}
