using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 8f;
    [SerializeField] private float _speedDefault = 1f;
    [SerializeField] private float _speedLevelUp = 0.2f;

    private void Update()
    {
        this.Moving();
    }

    void Moving()
    {
        if (this.IsGameOver()) return;
        this.MovingUp();
        this.MovingRight();
    }

    void MovingUp()
    {
        if (!ManagersCtrl.Instance.InputManager.PressSpace) return;
        PlayerCtrl.Instance.Rigidbody2D.velocity = Vector2.up * this._jumpForce;
    }
    
    void MovingRight()
    {
        transform.parent.position += Vector3.right * this._speedDefault * Time.deltaTime;
    }

    public void UpdateSpeed()
    {
        this._speedDefault += this._speedLevelUp;
    }
    
    public void SetGameOverSpeed()
    {
        this._speedDefault = 0;
    }    

    bool IsGameOver()
    {
        return PlayerCtrl.Instance.PlayerCollider.IsGameOver;
    }

}
