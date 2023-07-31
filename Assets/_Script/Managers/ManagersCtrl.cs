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

    [SerializeField] private LevelManager _levelManager;
    public LevelManager LevelManager => _levelManager;

    [SerializeField] private UIManager _uiManager;
    public UIManager UIManager => _uiManager;

    [SerializeField] private PlayerPrefsManager _playerPrefsManager;
    public PlayerPrefsManager PlayerPrefsManager => _playerPrefsManager;

    [SerializeField] private PlayerManager _playerManager;
    public PlayerManager PlayerManager => _playerManager;

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
        this.LoadLevelManager();
        this.LoadUIManager();
        this.LoadPlayerPrefsManager();
        this.LoadPlayerManager();
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

    void LoadLevelManager()
    {
        if (this._levelManager != null) return;
        this._levelManager = GetComponentInChildren<LevelManager>();
        Debug.LogWarning(transform.name + ": LoadLevelManager", gameObject);
    }

    void LoadUIManager()
    {
        if (this._uiManager != null) return;
        this._uiManager = GetComponentInChildren<UIManager>();
        Debug.LogWarning(transform.name + ": LoadUIManager", gameObject);
    }

    void LoadPlayerPrefsManager()
    {
        if (this._playerPrefsManager != null) return;
        this._playerPrefsManager = GetComponentInChildren<PlayerPrefsManager>();
        Debug.LogWarning(transform.name + ": LoadPlayerPrefsManager", gameObject);
    }

    void LoadPlayerManager()
    {
        if (this._playerManager != null) return;
        this._playerManager = GetComponentInChildren<PlayerManager>();
        Debug.LogWarning(transform.name + ": LoadPlayerManager", gameObject);
    }

}
