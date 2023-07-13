using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance { get => _instance; }

    [SerializeField] private PipeSpawner _pipeSpawner;
    public PipeSpawner PipeSpawner { get => _pipeSpawner; }

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPipeSpawner();
    }

    void LoadPipeSpawner()
    {
        if (this._pipeSpawner != null) return;
        this._pipeSpawner = GetComponentInChildren<PipeSpawner>();
        Debug.LogWarning(transform.name + ": LoadPipeSpawner", gameObject);
    }

}
