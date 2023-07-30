using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _levelStart = false;
    public bool LevelStart => _levelStart;

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerPrefsManager _playerPrefsManager;
    [SerializeField] private PipeSpawner _pipeSpawner;

    private void Start()
    {
        this._uiManager = ManagersCtrl.Instance.UIManager;
        this._inputManager = ManagersCtrl.Instance.InputManager;
        this._playerPrefsManager = ManagersCtrl.Instance.PlayerPrefsManager;
        this._pipeSpawner = SpawnerCtrl.Instance.PipeSpawner;
    }

    private void Update()
    {
        this.PlayerFristSpace();
    }

    void PlayerFristSpace()
    {
        if (this._levelStart) return;
        if (!this._inputManager.PressSpace) return;
        this._levelStart = true;
        PlayerCtrl.Instance.PlayerRigibody2D.SetRigiBody2D();
    }

    public void GameOver()
    {
        this.GameOverPlayer();
        this._pipeSpawner.gameObject.SetActive(false);
        Invoke(nameof(this.OnEnableGameOverMenu), 1f);
        this._playerPrefsManager.SaveTopScore();
        this.DisableScoreText();
    }

    void GameOverPlayer()
    {
        PlayerCtrl.Instance.PlayerAnimation.SetAnimaitonDead();
        PlayerCtrl.Instance.PlayerRigibody2D.SetGravityScaleZero();
        PlayerCtrl.Instance.Rigidbody2D.velocity = Vector2.zero;
        PlayerCtrl.Instance.PlayerMovement.gameObject.SetActive(false);
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

        int birdCount = PlayerPrefs.GetInt("BirdCount", 0);
        PlayerCtrl.Instance.PlayerAvatar.Avatars[birdCount].gameObject.SetActive(true);
        this._inputManager.gameObject.SetActive(true);
        PlayerCtrl.Instance.PlayerAnimation.GetAnimation();
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

}
