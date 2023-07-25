using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerCtrl : LoboMonoBehaviour
{
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance { get => _instance; }

    [SerializeField] private PlayerMovement _playerMovement;
    public PlayerMovement PlayerMovement { get => _playerMovement; }

    [SerializeField] private Rigidbody2D _rigidbody2D;
    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; }

    [SerializeField] private PlayerCollider _playerCollider;
    public PlayerCollider PlayerCollider { get => _playerCollider; }

    [SerializeField] private PlayerRigibody2D _playerRigibody2D;
    public PlayerRigibody2D PlayerRigibody2D { get => _playerRigibody2D; }

    [SerializeField] private PlayerAvatar _playerAvatar;
    public PlayerAvatar PlayerAvatar { get => _playerAvatar; }

    [SerializeField] private PlayerAnimation _playerAnimation;
    public PlayerAnimation PlayerAnimation { get => _playerAnimation; }

    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigidbody2D();
        this.LoadPlayerMovement();
        this.LoadPlayerCollider();
        this.LoadPlayerRigibody2D();
        this.LoadPlayerAvatar();
        this.LoadPlayerAnimation();
    }

    void LoadRigidbody2D()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        this._rigidbody2D.gravityScale = 0;
        Debug.LogWarning(transform.name + ": LoadRigidbody2D", gameObject);
    }

    void LoadPlayerMovement()
    {
        if (this._playerMovement != null) return;
        this._playerMovement = GetComponentInChildren<PlayerMovement>();
        Debug.LogWarning(transform.name + ": LoadPlayerMovement", gameObject);
    }

    void LoadPlayerCollider()
    {
        if (this._playerCollider != null) return;
        this._playerCollider = GetComponentInChildren<PlayerCollider>();
        Debug.LogWarning(transform.name + ": LoadPlayerCollider", gameObject);
    }

    void LoadPlayerRigibody2D()
    {
        if (this._playerRigibody2D != null) return;
        this._playerRigibody2D = GetComponentInChildren<PlayerRigibody2D>();
        Debug.LogWarning(transform.name + ": LoadPlayerRigibody2D", gameObject);
    }

    void LoadPlayerAvatar()
    {
        if (this._playerAvatar != null) return;
        this._playerAvatar = GetComponentInChildren<PlayerAvatar>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatar", gameObject);
    }

    void LoadPlayerAnimation()
    {
        if (this._playerAnimation != null) return;
        this._playerAnimation = GetComponentInChildren<PlayerAnimation>();
        Debug.LogWarning(transform.name + ": LoadPlayerAnimation", gameObject);
    }

}
