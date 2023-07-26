using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]

public class PlayerCollider : LoboMonoBehaviour
{
    [SerializeField] private CircleCollider2D _circleCollider2D;
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCircleCollider2D();
    }

    void LoadCircleCollider2D()
    {
        if (this._circleCollider2D != null) return;
        this._circleCollider2D = GetComponent<CircleCollider2D>();
        this._circleCollider2D.isTrigger = true;
        Debug.LogWarning(transform.name + ": LoadCircleCollider2D", gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ManagersCtrl.Instance.GameManager.GameOver();
    }

}
