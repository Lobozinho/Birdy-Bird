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

}
