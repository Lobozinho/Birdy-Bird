using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _levelStart = false;
    public bool LevelStart => _levelStart;
    [Header(" ")]
    [SerializeField] private ManagersCtrl _managersCtrl;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerPrefsManager _playerPrefsManager;
    [SerializeField] private PlayerManager _playerManager;
    [Header(" ")]
    [SerializeField] private PipeSpawner _pipeSpawner;

    private void Start()
    {
        this._managersCtrl = ManagersCtrl.Instance;
        this._uiManager = this._managersCtrl.UIManager;
        this._inputManager = ManagersCtrl.Instance.InputManager;
        this._playerPrefsManager = ManagersCtrl.Instance.PlayerPrefsManager;
        this._playerManager = ManagersCtrl.Instance.PlayerManager;
        this._pipeSpawner = SpawnerCtrl.Instance.PipeSpawner;
    }

    private void Update()
    {
        this.PlayerFristSpace();
    }

    void PlayerFristSpace()
    {
        if (this._levelStart) return;
        if (!this._inputManager.IsJump) return;
        this._levelStart = true;
        PlayerCtrl.Instance.PlayerRigibody2D.SetRigiBody2D();
    }

    public void GameOver()
    {
        this.GameOverPlayer();
        this.DisablePipeSpawner();
        this._playerPrefsManager.SaveTopScore();
        this.DisableScoreText();
        this.SaveBirdCount();
        Invoke(nameof(this.OnEnableGameOverMenu), 1f);
    }

    void GameOverPlayer()
    {
        this._playerManager.GameOverPlayer();
    }

    public async void ResetGame()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        
        while (!asyncLoad.isDone)
        {
            await Task.Yield();
        }

        this.DisableMainMenu();
        this.OnEnableScoreText();

        PlayerCtrl.Instance.PlayerAvatar.ShowAvatar(this.GetBirdCount());
        PlayerCtrl.Instance.PlayerAnimation.GetAnimation();

        ManagersCtrl.Instance.InputManager.gameObject.SetActive(true);
    }

    void OnEnableGameOverMenu()
    {
        this._uiManager.OnEnableGameOverMenu();
    }

    void DisableScoreText()
    {
        this._uiManager.DisableScoreText();
    }

    void OnEnableScoreText()
    {
        this._uiManager.OnEnableScoreText();
    }

    void DisableMainMenu()
    {
        this._uiManager.DisableMainMenu();
    }

    void DisablePipeSpawner()
    {
        this._pipeSpawner.gameObject.SetActive(false);
    }

    int GetBirdCount()
    {
        return this._playerPrefsManager.GetBirdCount();
    }

    void SaveBirdCount()
    {
        this._playerPrefsManager.SaveBirdCount();
    }

}
