using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance { get => _instance; }

    [SerializeField] private PipeSpawner _pipeSpawner;
    public PipeSpawner PipeSpawner { get => _pipeSpawner; }

    [SerializeField] private BgSpawner _bgSpawner;
    public BgSpawner BgSpawner { get => _bgSpawner; }

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPipeSpawner();
        this.LoadBgSpawner();
    }

    void LoadPipeSpawner()
    {
        if (this._pipeSpawner != null) return;
        this._pipeSpawner = GetComponentInChildren<PipeSpawner>();
        Debug.LogWarning(transform.name + ": LoadPipeSpawner", gameObject);
    }

    void LoadBgSpawner()
    {
        if (this._bgSpawner != null) return;
        this._bgSpawner = GetComponentInChildren<BgSpawner>();
        Debug.LogWarning(transform.name + ": LoadBgSpawner", gameObject);
    }

}
