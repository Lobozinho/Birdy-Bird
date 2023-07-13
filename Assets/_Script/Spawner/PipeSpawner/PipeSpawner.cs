using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : Spawner
{
    [SerializeField] private float _offsetPosition = 3.5f;
    [SerializeField] private float _timeDelay = 8;

    private void Start()
    {
        InvokeRepeating(nameof(this.PipeSpawning), 0.5f, this._timeDelay);
    }

    void PipeSpawning()
    {
        float playerPosX = PlayerCtrl.Instance.transform.position.x;
        Vector3 pos = new Vector3 (playerPosX + this._offsetPosition, 0, 0);
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, pos, transform.rotation);
        obj.gameObject.SetActive(true);
    }

}
