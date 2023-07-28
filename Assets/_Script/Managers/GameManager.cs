using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _levelStart = false;
    public bool LevelStart => _levelStart;

    private void Update()
    {
        this.PlayerFristSpace();
    }

    void PlayerFristSpace()
    {
        if (this._levelStart) return;
        if (!ManagersCtrl.Instance.InputManager.PressSpace) return;
        this._levelStart = true;
        PlayerCtrl.Instance.PlayerRigibody2D.SetRigiBody2D();
    }

    public void GameOver()
    {
        this.GameOverPlayer();
        SpawnerCtrl.Instance.PipeSpawner.gameObject.SetActive(false);
        Invoke(nameof(this.OnEnableGameOverMenu), 1f);
        ManagersCtrl.Instance.PlayerPrefsManager.SaveTopScore();
        UICtrl.Instance.ScoreText.SetActive(false);
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
        UICtrl.Instance.MainMenu.SetActive(false);
        int birdCount = PlayerPrefs.GetInt("BirdCount", 0);
        PlayerCtrl.Instance.PlayerAvatar.Avatars[birdCount].gameObject.SetActive(true);
        ManagersCtrl.Instance.InputManager.gameObject.SetActive(true);
        PlayerCtrl.Instance.PlayerAnimation.GetAnimation();
        UICtrl.Instance.ScoreText.SetActive(true);
    }

    void OnEnableGameOverMenu()
    {
        ManagersCtrl.Instance.UIManager.OnEnableGameOverMenu();
    }    

}
