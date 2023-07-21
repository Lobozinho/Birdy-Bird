using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    private static UICtrl _instance;
    public static UICtrl Instance => _instance;

    [SerializeField] private GameObject _mainMenu;
    public GameObject MainMenu => _mainMenu;

    [SerializeField] private GameObject _birdSelectMenu;
    public GameObject BirdSelectMenu => _birdSelectMenu;

    [SerializeField] private GameObject _leaderBoardMenu;
    public GameObject LeaderBoardMenu => _leaderBoardMenu;

    [SerializeField] private BirdSelect _birdSelect;
    public BirdSelect BirdSelect => _birdSelect;

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
        this.LoadBirdSelect();
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
        this._birdSelectMenu = GameObject.Find("BirdSelectMenu");
        Debug.LogWarning(transform.name + ": LoadBirdSelectMenu", gameObject);
    }

    void LoadLeaderBoardMenu()
    {
        if (this._leaderBoardMenu != null) return;
        this._leaderBoardMenu = GameObject.Find("LeaderBoardMenu");
        Debug.LogWarning(transform.name + ": LoadLeaderBoardMenu", gameObject);
    }

    void LoadBirdSelect()
    {
        if (this._birdSelect != null) return;
        this._birdSelect = GetComponentInChildren<BirdSelect>();
        Debug.LogWarning(transform.name + ": LoadBirdSelect", gameObject);
    }

}
