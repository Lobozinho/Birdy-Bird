using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigibody2D : LoboMonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _gravityScale = 6;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigiBody2D();
    }

    protected virtual void LoadRigiBody2D()
    {
        if (this._rigidbody2D != null) return;
        this._rigidbody2D = GetComponentInParent<Rigidbody2D>();
        Debug.LogWarning(transform.name + ": LoadRigiBody2D", gameObject);
    }

    public void SetRigiBody2D()
    {
        this._rigidbody2D.gravityScale = this._gravityScale;
    }

}
