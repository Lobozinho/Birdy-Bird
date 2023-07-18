using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersCtrl : LoboMonoBehaviour
{
    private static ManagersCtrl _instance;
    public static ManagersCtrl Instance => _instance;

    [SerializeField] private InputManager _inputManager;
    public InputManager InputManager => _inputManager; 

    [SerializeField] private GameManager _gameManager;
    public GameManager GameManager => _gameManager;

    [SerializeField] private ScoreManager _scoreManager;
    public ScoreManager ScoreManager => _scoreManager;

    protected override void Awake()
    {
        if (ManagersCtrl._instance != null) Debug.LogError("only 1 ManagersCtrl allow to exist");
        ManagersCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputManager();
        this.LoadGameManager();
        this.LoadScoreManager();
    }

    void LoadInputManager()
    {
        if (this._inputManager != null) return;
        this._inputManager = GetComponentInChildren<InputManager>();
        Debug.LogWarning(transform.name + ": LoadInputManager", gameObject);
    }

    void LoadGameManager()
    {
        if (this._gameManager != null) return;
        this._gameManager = GetComponentInChildren<GameManager>();
        Debug.LogWarning(transform.name + ": LoadGameManager", gameObject);
    }

    void LoadScoreManager()
    {
        if (this._scoreManager != null) return;
        this._scoreManager = GetComponentInChildren<ScoreManager>();
        Debug.LogWarning(transform.name + ": LoadScoreManager", gameObject);
    }

}
