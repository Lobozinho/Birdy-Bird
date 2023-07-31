using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    private static UICtrl _instance;
    public static UICtrl Instance => _instance;

    [SerializeField] private GameObject _mainMenu;
    public GameObject MainMenu => _mainMenu;

    [SerializeField] private GameObject _scoreText;
    public GameObject ScoreText => _scoreText;

    [SerializeField] private GameObject _gameOverMenu;
    public GameObject GameOverMenu => _gameOverMenu;

    [SerializeField] private BirdSelectMenu _birdSelectMenu;
    public BirdSelectMenu BirdSelectMenu => _birdSelectMenu;

    [SerializeField] private LeaderBoardMenu _leaderBoardMenu;
    public LeaderBoardMenu LeaderBoardMenu => _leaderBoardMenu;

    protected override void Awake()
    {
        if (UICtrl._instance != null) Debug.LogError("only 1 UICtrl allow to exist");
        UICtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMainMenu();
        this.LoadBirdSelectMenu();
        this.LoadLeaderBoardMenu();
        this.LoadGameOverMenu();
        this.LoadScoreText();
    }

    void LoadMainMenu()
    {
        if (this._mainMenu != null) return;
        this._mainMenu = GameObject.Find("MainMenu");
        Debug.LogWarning(transform.name + ": LoadMainMenu", gameObject);
    }

    void LoadBirdSelectMenu()
    {
        if (this._birdSelectMenu != null) return;
        this._birdSelectMenu = GetComponentInChildren<BirdSelectMenu>();
        Debug.LogWarning(transform.name + ": LoadBirdSelectMenu", gameObject);
    }

    void LoadLeaderBoardMenu()
    {
        if (this._leaderBoardMenu != null) return;
        this._leaderBoardMenu = GetComponentInChildren<LeaderBoardMenu>();
        Debug.LogWarning(transform.name + ": LoadLeaderBoardMenu", gameObject);
    }

    void LoadGameOverMenu()
    {
        if (this._gameOverMenu != null) return;
        this._gameOverMenu = GameObject.Find("GameOverMenu");
        Debug.LogWarning(transform.name + ": LoadGameOverMenu", gameObject);
    }

    void LoadScoreText()
    {
        if (this._scoreText != null) return;
        this._scoreText = GameObject.Find("ScoreText");
        Debug.LogWarning(transform.name + ": LoadScoreText", gameObject);
    }

}
