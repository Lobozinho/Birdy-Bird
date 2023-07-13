using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersCtrl : LoboMonoBehaviour
{
    private static ManagersCtrl _instance;
    public static ManagersCtrl Instance { get => _instance; }

    [SerializeField] private InputManager _inputManager;
    public InputManager InputManager { get => _inputManager; }

    protected override void Awake()
    {
        if (ManagersCtrl._instance != null) Debug.LogError("only 1 ManagersCtrl allow to exist");
        ManagersCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputManager();
    }

    protected virtual void LoadInputManager()
    {
        if (this._inputManager != null) return;
        this._inputManager = GetComponentInChildren<InputManager>();
        Debug.LogWarning(transform.name + ": LoadInputManager", gameObject);
    }

}
