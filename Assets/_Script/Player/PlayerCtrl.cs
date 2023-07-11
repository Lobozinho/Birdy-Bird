using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance { get => _instance; }

    [SerializeField] private Rigidbody2D _rigidbody2D;
    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; }

    [SerializeField] private PlayerMovement _playerMovement;
    public PlayerMovement PlayerMovement { get => _playerMovement; }

    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigiBody2D();
        this.LoadPlayerMovement();
    }

    protected virtual void LoadRigiBody2D()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        Debug.LogWarning(transform.name + ": LoadRigiBody2D", gameObject);
    }

    protected virtual void LoadPlayerMovement()
    {
        if (this._playerMovement != null) return;
        this._playerMovement = GetComponentInChildren<PlayerMovement>();
        Debug.LogWarning(transform.name + ": LoadPlayerMovement", gameObject);
    }

}
