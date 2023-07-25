using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _levelStart = false;
    public bool LevelStart => _levelStart;

    [SerializeField] private bool _gameStart = false;
    public bool GameStart => _gameStart;

    private void Update()
    {
        this.PlayerFristSpace();
        this.GameOver();
    }

    void PlayerFristSpace()
    {
        if (this._levelStart) return;
        if (!ManagersCtrl.Instance.InputManager.PressSpace) return;
        this._levelStart = true;
        PlayerCtrl.Instance.PlayerRigibody2D.SetRigiBody2D();
    }

    void GameOver()
    {
        if(!PlayerCtrl.Instance.PlayerCollider.IsGameOver) return;

        this.GameOverPlayer();
        // kiem tra xem animation dead da xong chua
        //SceneManager.LoadScene(0);
    }

    void GameOverPlayer()
    {
        PlayerCtrl.Instance.PlayerAnimation.SetAnimaitonDead();
        PlayerCtrl.Instance.PlayerMovement.SetGameOverSpeed();
        PlayerCtrl.Instance.PlayerRigibody2D.SetGravityScaleZero();
    }

    public void GameStarted()
    {
        this._gameStart = true;
    }

}
