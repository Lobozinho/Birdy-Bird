using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _levelStart = false;
    public bool LevelStart => _levelStart;

    [SerializeField] private bool _gameStart;
    public bool GameStart => _gameStart;

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
        SpawnerCtrl.Instance.gameObject.SetActive(false);
        UICtrl.Instance.GameOverMenu.SetActive(true);
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
        this._gameStart = true;
        UICtrl.Instance.MainMenu.SetActive(false);
        int index = UICtrl.Instance.BirdSelect.BirdCount;
        PlayerCtrl.Instance.PlayerAvatar.Avatars[index].gameObject.SetActive(true);
    }

    public void GameStarted()
    {
        this._gameStart = true;
    }

}
