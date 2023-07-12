using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : Spawner
{
    [SerializeField] private Vector3 _spawnPosition = new Vector3 (3, 0, 0);
    [SerializeField] private float _timeDelay = 8;

    private void Start()
    {
        InvokeRepeating(nameof(this.PipeSpawning), 0.5f, this._timeDelay);
    }

    void PipeSpawning()
    {
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, this._spawnPosition, transform.rotation);
        obj.gameObject.SetActive(true);
    }

}
