using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerCtrl _playerCtrl;

    private void Start()
    {
        this._playerCtrl = PlayerCtrl.Instance;
    }

    public void GameOverPlayer()
    {
        this._playerCtrl.PlayerAnimation.SetAnimaitonDead();
        this._playerCtrl.PlayerRigibody2D.SetGravityScaleZero();
        this._playerCtrl.Rigidbody2D.velocity = Vector2.zero;
        this._playerCtrl.PlayerMovement.gameObject.SetActive(false);
    }

    public void ShowAvatar(int birdCount)
    {
        this._playerCtrl.PlayerAvatar.ShowAvatar(birdCount);
    }

    public void GetAnimation()
    {
        this._playerCtrl.PlayerAnimation.GetAnimation();
    }

}
