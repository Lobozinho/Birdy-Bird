using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpawner : Spawner
{
    [Header("Bg Spawner")]
    [SerializeField] private float _offset;
    [SerializeField] private Vector3 _currentBg;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this._offset = Camera.main.orthographicSize * Camera.main.aspect;
        this._currentBg = transform.position;
    }

    private void FixedUpdate()
    {
        this.UpdateBg();
    }

    void UpdateBg()
    {
        float PlayerPosY = PlayerCtrl.Instance.transform.position.x;
        if (PlayerPosY - this._currentBg.x < this._offset) return;
        this.BgSpawning(this._currentBg);
    }

    public void BgSpawning(Vector3 pos)
    {
        Transform prefab = this.GetPrefabs();

        Quaternion rot = Quaternion.identity;
        pos.x += this._offset * 3;
        
        Transform obj = this.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
        this._currentBg = obj.position;
    }

    Transform GetPrefabs()
    {
        
        if(this.GetLevelGame() < 7) return this.GetPrefabLevel();

        return this.RandomPrefab();
    }    

    Transform GetPrefabLevel()
    {
        return this.prefabs[this.GetGameLevel() - 1];
    }

    int GetGameLevel()
    {
        if (this.GetLevelGame() > this.prefabs.Count) return this.prefabs.Count;
        return this.GetLevelGame();
    }

    int GetLevelGame()
    {
        return ManagersCtrl.Instance.LevelManager.GameLevel;
    }

}
